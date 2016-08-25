namespace ProfileOperations
{
    partial class Cosmetics
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
            this.soapsComboBox1 = new System.Windows.Forms.ComboBox();
            this.selectedListBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceOfSoap = new System.Windows.Forms.TextBox();
            this.btn_To_Cart = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cosmetic Store";
            // 
            // soapsComboBox1
            // 
            this.soapsComboBox1.FormattingEnabled = true;
            this.soapsComboBox1.Location = new System.Drawing.Point(81, 98);
            this.soapsComboBox1.Name = "soapsComboBox1";
            this.soapsComboBox1.Size = new System.Drawing.Size(121, 28);
            this.soapsComboBox1.TabIndex = 1;
            this.soapsComboBox1.Text = "Select";
            this.soapsComboBox1.SelectedIndexChanged += new System.EventHandler(this.soapsComboBox1_SelectedIndexChanged);
            // 
            // selectedListBox1
            // 
            this.selectedListBox1.Enabled = false;
            this.selectedListBox1.FormattingEnabled = true;
            this.selectedListBox1.ItemHeight = 20;
            this.selectedListBox1.Location = new System.Drawing.Point(142, 199);
            this.selectedListBox1.Name = "selectedListBox1";
            this.selectedListBox1.Size = new System.Drawing.Size(120, 84);
            this.selectedListBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soaps :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected Items :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price :";
            // 
            // PriceOfSoap
            // 
            this.PriceOfSoap.Location = new System.Drawing.Point(290, 100);
            this.PriceOfSoap.Name = "PriceOfSoap";
            this.PriceOfSoap.Size = new System.Drawing.Size(100, 26);
            this.PriceOfSoap.TabIndex = 6;
            // 
            // btn_To_Cart
            // 
            this.btn_To_Cart.Location = new System.Drawing.Point(187, 146);
            this.btn_To_Cart.Name = "btn_To_Cart";
            this.btn_To_Cart.Size = new System.Drawing.Size(75, 33);
            this.btn_To_Cart.TabIndex = 7;
            this.btn_To_Cart.Text = "To Cart";
            this.btn_To_Cart.UseVisualStyleBackColor = true;
            this.btn_To_Cart.Click += new System.EventHandler(this.btn_To_Cart_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.Enabled = false;
            this.totalPrice.Location = new System.Drawing.Point(142, 300);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(100, 26);
            this.totalPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Price :";
            // 
            // Cosmetics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.btn_To_Cart);
            this.Controls.Add(this.PriceOfSoap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedListBox1);
            this.Controls.Add(this.soapsComboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Cosmetics";
            this.Text = "Cosmetics";
            this.Load += new System.EventHandler(this.Cosmetics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox soapsComboBox1;
        private System.Windows.Forms.ListBox selectedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceOfSoap;
        private System.Windows.Forms.Button btn_To_Cart;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label5;
    }
}