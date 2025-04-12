namespace WinformsApp
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(89, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(146, 23);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(86, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(149, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnSave_Click
            // 
            btnSave.Location = new Point(160, 197);
            btnSave.Name = "btnSave_Click";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 54);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 126);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Email:";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 277);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnSave;
        private Label label1;
        private Label label2;
    }
}