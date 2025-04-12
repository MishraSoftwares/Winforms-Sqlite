using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using System.Xml.Linq;
using WinformsApp.Models;
using WinformsApp.Repository;

namespace WinformsApp
{
    public partial class MainForm : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IServiceProvider _serviceProvider;
        private BindingSource _customerBindingSource = new();

        public MainForm(
         ICustomerRepository customerRepository,
         IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _serviceProvider = serviceProvider;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadCustomersAsync();
        }

        private async Task LoadCustomersAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            _customerBindingSource.DataSource = customers;
            dataGridView1.DataSource = _customerBindingSource;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // Use DI to create the form
            var customerForm = _serviceProvider.GetRequiredService<CustomerForm>();
            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                await _customerRepository.AddAsync(customerForm.Customer);
                await LoadCustomersAsync();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_customerBindingSource.Current is Customer selectedCustomer)
            {
                await _customerRepository.DeleteAsync(selectedCustomer.Id);
                await LoadCustomersAsync();
            }
        }
    }
}
