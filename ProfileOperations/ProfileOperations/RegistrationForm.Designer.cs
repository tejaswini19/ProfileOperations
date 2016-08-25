namespace ProfileOperations
{
    partial class RegistrationForm
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
            this.r_Form = new System.Windows.Forms.Label();
            this.f_Name = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.r_B_Male = new System.Windows.Forms.RadioButton();
            this.r_B_Female = new System.Windows.Forms.RadioButton();
            this.address = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.d_Of_Birth = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.data_Saved1 = new System.Windows.Forms.TextBox();
            this.data_Saved = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // r_Form
            // 
            this.r_Form.AutoSize = true;
            this.r_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_Form.Location = new System.Drawing.Point(264, 9);
            this.r_Form.Name = "r_Form";
            this.r_Form.Size = new System.Drawing.Size(272, 37);
            this.r_Form.TabIndex = 0;
            this.r_Form.Text = "Registration Form";
            // 
            // f_Name
            // 
            this.f_Name.AutoSize = true;
            this.f_Name.Location = new System.Drawing.Point(23, 73);
            this.f_Name.Name = "f_Name";
            this.f_Name.Size = new System.Drawing.Size(94, 20);
            this.f_Name.TabIndex = 1;
            this.f_Name.Text = "First Name :";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(23, 106);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(94, 20);
            this.l_Name.TabIndex = 2;
            this.l_Name.Text = "Last Name :";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(133, 73);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(171, 26);
            this.firstName.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(133, 106);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(171, 26);
            this.lastName.TabIndex = 4;
            this.lastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // r_B_Male
            // 
            this.r_B_Male.AutoSize = true;
            this.r_B_Male.Location = new System.Drawing.Point(47, 149);
            this.r_B_Male.Name = "r_B_Male";
            this.r_B_Male.Size = new System.Drawing.Size(68, 24);
            this.r_B_Male.TabIndex = 5;
            this.r_B_Male.TabStop = true;
            this.r_B_Male.Text = "Male";
            this.r_B_Male.UseVisualStyleBackColor = true;
            // 
            // r_B_Female
            // 
            this.r_B_Female.AutoSize = true;
            this.r_B_Female.Location = new System.Drawing.Point(209, 148);
            this.r_B_Female.Name = "r_B_Female";
            this.r_B_Female.Size = new System.Drawing.Size(87, 24);
            this.r_B_Female.TabIndex = 6;
            this.r_B_Female.TabStop = true;
            this.r_B_Female.Text = "Female";
            this.r_B_Female.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(23, 189);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(76, 20);
            this.address.TabIndex = 7;
            this.address.Text = "Address :";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(133, 189);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(190, 78);
            this.addressBox.TabIndex = 8;
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(429, 136);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(68, 20);
            this.course.TabIndex = 9;
            this.course.Text = "Course :";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            ".NET",
            "C#",
            "Python"});
            this.checkedListBox1.Location = new System.Drawing.Point(551, 136);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(190, 130);
            this.checkedListBox1.TabIndex = 10;
            // 
            // d_Of_Birth
            // 
            this.d_Of_Birth.AutoSize = true;
            this.d_Of_Birth.Location = new System.Drawing.Point(429, 76);
            this.d_Of_Birth.Name = "d_Of_Birth";
            this.d_Of_Birth.Size = new System.Drawing.Size(107, 20);
            this.d_Of_Birth.TabIndex = 11;
            this.d_Of_Birth.Text = "Date of Birth :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(551, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(398, 284);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 29);
            this.btn_Submit.TabIndex = 13;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // data_Saved1
            // 
            this.data_Saved1.Enabled = false;
            this.data_Saved1.Location = new System.Drawing.Point(133, 333);
            this.data_Saved1.Multiline = true;
            this.data_Saved1.Name = "data_Saved1";
            this.data_Saved1.Size = new System.Drawing.Size(346, 185);
            this.data_Saved1.TabIndex = 14;
            // 
            // data_Saved
            // 
            this.data_Saved.AutoSize = true;
            this.data_Saved.Location = new System.Drawing.Point(23, 346);
            this.data_Saved.Name = "data_Saved";
            this.data_Saved.Size = new System.Drawing.Size(101, 20);
            this.data_Saved.TabIndex = 15;
            this.data_Saved.Text = "Data Saved :";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(398, 556);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 30);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 626);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.data_Saved);
            this.Controls.Add(this.data_Saved1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.d_Of_Birth);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.course);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.r_B_Female);
            this.Controls.Add(this.r_B_Male);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.f_Name);
            this.Controls.Add(this.r_Form);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label r_Form;
        private System.Windows.Forms.Label f_Name;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.RadioButton r_B_Male;
        private System.Windows.Forms.RadioButton r_B_Female;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label d_Of_Birth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox data_Saved1;
        private System.Windows.Forms.Label data_Saved;
        private System.Windows.Forms.Button btn_Back;
    }
}