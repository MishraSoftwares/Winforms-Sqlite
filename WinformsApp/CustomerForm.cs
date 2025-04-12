


using SqliteDataAccess.Entities;

namespace WinformsApp
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; private set; } = new();
        public CustomerForm()
        {
            InitializeComponent();

            // Bind controls to customer properties
            txtName.DataBindings.Add("Text", Customer, nameof(Customer.Name));
            txtEmail.DataBindings.Add("Text", Customer, nameof(Customer.Email));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
