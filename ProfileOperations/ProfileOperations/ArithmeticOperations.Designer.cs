namespace ProfileOperations
{
    partial class ArithmeticOperations
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
            this.varA = new System.Windows.Forms.TextBox();
            this.varB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Twelve = new System.Windows.Forms.Button();
            this.btn_Four = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arithmetic Operations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter A :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter B :";
            // 
            // varA
            // 
            this.varA.Location = new System.Drawing.Point(91, 55);
            this.varA.Name = "varA";
            this.varA.Size = new System.Drawing.Size(100, 26);
            this.varA.TabIndex = 3;
            // 
            // varB
            // 
            this.varB.Location = new System.Drawing.Point(91, 98);
            this.varB.Name = "varB";
            this.varB.Size = new System.Drawing.Size(100, 26);
            this.varB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // ans
            // 
            this.ans.Enabled = false;
            this.ans.Location = new System.Drawing.Point(252, 69);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(120, 26);
            this.ans.TabIndex = 6;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(47, 176);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 50);
            this.add.TabIndex = 7;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(143, 176);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 50);
            this.sub.TabIndex = 8;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(235, 176);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 50);
            this.mul.TabIndex = 9;
            this.mul.Text = "x";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(332, 176);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 50);
            this.div.TabIndex = 10;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(235, 288);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 37);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tax Calculator";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(650, 60);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 26);
            this.amount.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Amount :";
            // 
            // btn_Twelve
            // 
            this.btn_Twelve.Location = new System.Drawing.Point(590, 135);
            this.btn_Twelve.Name = "btn_Twelve";
            this.btn_Twelve.Size = new System.Drawing.Size(90, 42);
            this.btn_Twelve.TabIndex = 15;
            this.btn_Twelve.Text = "12% Tax";
            this.btn_Twelve.UseVisualStyleBackColor = true;
            this.btn_Twelve.Click += new System.EventHandler(this.btn_Twelve_Click);
            // 
            // btn_Four
            // 
            this.btn_Four.Location = new System.Drawing.Point(720, 134);
            this.btn_Four.Name = "btn_Four";
            this.btn_Four.Size = new System.Drawing.Size(91, 43);
            this.btn_Four.TabIndex = 16;
            this.btn_Four.Text = "4% Tax";
            this.btn_Four.UseVisualStyleBackColor = true;
            this.btn_Four.Click += new System.EventHandler(this.btn_Four_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tax :";
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(650, 223);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 26);
            this.total.TabIndex = 18;
            // 
            // ArithmeticOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 341);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Four);
            this.Controls.Add(this.btn_Twelve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.varB);
            this.Controls.Add(this.varA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArithmeticOperations";
            this.Text = "ArithmeticOperations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox varA;
        private System.Windows.Forms.TextBox varB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Twelve;
        private System.Windows.Forms.Button btn_Four;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox total;
    }
}