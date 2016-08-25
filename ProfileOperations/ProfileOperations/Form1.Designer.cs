namespace ProfileOperations
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.fullName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.r_b_male = new System.Windows.Forms.RadioButton();
            this.r_b_Female = new System.Windows.Forms.RadioButton();
            this.groupBox_radioButtons = new System.Windows.Forms.GroupBox();
            this.r_B_Orange = new System.Windows.Forms.RadioButton();
            this.r_B_Blue = new System.Windows.Forms.RadioButton();
            this.r_B_Pink = new System.Windows.Forms.RadioButton();
            this.r_B_Green = new System.Windows.Forms.RadioButton();
            this.groupBox_radioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name :";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(135, 69);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 26);
            this.fname.TabIndex = 3;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(388, 69);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(100, 26);
            this.lName.TabIndex = 4;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(244, 177);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(154, 40);
            this.btnClick.TabIndex = 5;
            this.btnClick.Text = "Click for Full Name";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // fullName
            // 
            this.fullName.Enabled = false;
            this.fullName.Location = new System.Drawing.Point(211, 239);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(205, 26);
            this.fullName.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(279, 303);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // r_b_male
            // 
            this.r_b_male.AutoSize = true;
            this.r_b_male.Location = new System.Drawing.Point(135, 127);
            this.r_b_male.Name = "r_b_male";
            this.r_b_male.Size = new System.Drawing.Size(68, 24);
            this.r_b_male.TabIndex = 8;
            this.r_b_male.TabStop = true;
            this.r_b_male.Text = "Male";
            this.r_b_male.UseVisualStyleBackColor = true;
            // 
            // r_b_Female
            // 
            this.r_b_Female.AutoSize = true;
            this.r_b_Female.Location = new System.Drawing.Point(329, 127);
            this.r_b_Female.Name = "r_b_Female";
            this.r_b_Female.Size = new System.Drawing.Size(87, 24);
            this.r_b_Female.TabIndex = 9;
            this.r_b_Female.TabStop = true;
            this.r_b_Female.Text = "Female";
            this.r_b_Female.UseVisualStyleBackColor = true;
            // 
            // groupBox_radioButtons
            // 
            this.groupBox_radioButtons.Controls.Add(this.r_B_Green);
            this.groupBox_radioButtons.Controls.Add(this.r_B_Pink);
            this.groupBox_radioButtons.Controls.Add(this.r_B_Blue);
            this.groupBox_radioButtons.Controls.Add(this.r_B_Orange);
            this.groupBox_radioButtons.Location = new System.Drawing.Point(585, 69);
            this.groupBox_radioButtons.Name = "groupBox_radioButtons";
            this.groupBox_radioButtons.Size = new System.Drawing.Size(200, 264);
            this.groupBox_radioButtons.TabIndex = 10;
            this.groupBox_radioButtons.TabStop = false;
            this.groupBox_radioButtons.Text = "Color Box";
            // 
            // r_B_Orange
            // 
            this.r_B_Orange.AutoSize = true;
            this.r_B_Orange.Location = new System.Drawing.Point(26, 58);
            this.r_B_Orange.Name = "r_B_Orange";
            this.r_B_Orange.Size = new System.Drawing.Size(87, 24);
            this.r_B_Orange.TabIndex = 0;
            this.r_B_Orange.TabStop = true;
            this.r_B_Orange.Text = "Orange";
            this.r_B_Orange.UseVisualStyleBackColor = true;
            this.r_B_Orange.CheckedChanged += new System.EventHandler(this.r_B_Orange_CheckedChanged);
            // 
            // r_B_Blue
            // 
            this.r_B_Blue.AutoSize = true;
            this.r_B_Blue.Location = new System.Drawing.Point(26, 108);
            this.r_B_Blue.Name = "r_B_Blue";
            this.r_B_Blue.Size = new System.Drawing.Size(66, 24);
            this.r_B_Blue.TabIndex = 1;
            this.r_B_Blue.TabStop = true;
            this.r_B_Blue.Text = "Blue";
            this.r_B_Blue.UseVisualStyleBackColor = true;
            this.r_B_Blue.CheckedChanged += new System.EventHandler(this.r_B_Blue_CheckedChanged);
            // 
            // r_B_Pink
            // 
            this.r_B_Pink.AutoSize = true;
            this.r_B_Pink.Location = new System.Drawing.Point(26, 155);
            this.r_B_Pink.Name = "r_B_Pink";
            this.r_B_Pink.Size = new System.Drawing.Size(64, 24);
            this.r_B_Pink.TabIndex = 2;
            this.r_B_Pink.TabStop = true;
            this.r_B_Pink.Text = "Pink";
            this.r_B_Pink.UseVisualStyleBackColor = true;
            this.r_B_Pink.CheckedChanged += new System.EventHandler(this.r_B_Pink_CheckedChanged);
            // 
            // r_B_Green
            // 
            this.r_B_Green.AutoSize = true;
            this.r_B_Green.Location = new System.Drawing.Point(26, 206);
            this.r_B_Green.Name = "r_B_Green";
            this.r_B_Green.Size = new System.Drawing.Size(79, 24);
            this.r_B_Green.TabIndex = 3;
            this.r_B_Green.TabStop = true;
            this.r_B_Green.Text = "Green";
            this.r_B_Green.UseVisualStyleBackColor = true;
            this.r_B_Green.CheckedChanged += new System.EventHandler(this.r_B_Green_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 538);
            this.Controls.Add(this.groupBox_radioButtons);
            this.Controls.Add(this.r_b_Female);
            this.Controls.Add(this.r_b_male);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_radioButtons.ResumeLayout(false);
            this.groupBox_radioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton r_b_male;
        private System.Windows.Forms.RadioButton r_b_Female;
        private System.Windows.Forms.GroupBox groupBox_radioButtons;
        private System.Windows.Forms.RadioButton r_B_Green;
        private System.Windows.Forms.RadioButton r_B_Pink;
        private System.Windows.Forms.RadioButton r_B_Blue;
        private System.Windows.Forms.RadioButton r_B_Orange;
    }
}

