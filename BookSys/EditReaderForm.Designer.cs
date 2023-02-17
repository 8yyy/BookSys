namespace BookSys
{
    partial class EditReaderForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBorrovQtyTB = new System.Windows.Forms.TextBox();
            this.rdQQTB = new System.Windows.Forms.TextBox();
            this.rdDeptTB = new System.Windows.Forms.TextBox();
            this.rdNameTB = new System.Windows.Forms.TextBox();
            this.rdIDTB = new System.Windows.Forms.TextBox();
            this.rdTypeCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(172, 242);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "修改";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "rdBorrovQty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "rdQQ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "rdDept";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "rdName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "rdType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "rdID";
            // 
            // rdBorrovQtyTB
            // 
            this.rdBorrovQtyTB.Location = new System.Drawing.Point(172, 197);
            this.rdBorrovQtyTB.Name = "rdBorrovQtyTB";
            this.rdBorrovQtyTB.Size = new System.Drawing.Size(139, 21);
            this.rdBorrovQtyTB.TabIndex = 4;
            // 
            // rdQQTB
            // 
            this.rdQQTB.Location = new System.Drawing.Point(172, 170);
            this.rdQQTB.Name = "rdQQTB";
            this.rdQQTB.Size = new System.Drawing.Size(139, 21);
            this.rdQQTB.TabIndex = 5;
            // 
            // rdDeptTB
            // 
            this.rdDeptTB.Location = new System.Drawing.Point(172, 143);
            this.rdDeptTB.Name = "rdDeptTB";
            this.rdDeptTB.Size = new System.Drawing.Size(139, 21);
            this.rdDeptTB.TabIndex = 6;
            // 
            // rdNameTB
            // 
            this.rdNameTB.Location = new System.Drawing.Point(172, 116);
            this.rdNameTB.Name = "rdNameTB";
            this.rdNameTB.Size = new System.Drawing.Size(139, 21);
            this.rdNameTB.TabIndex = 7;
            // 
            // rdIDTB
            // 
            this.rdIDTB.Location = new System.Drawing.Point(172, 62);
            this.rdIDTB.Name = "rdIDTB";
            this.rdIDTB.Size = new System.Drawing.Size(139, 21);
            this.rdIDTB.TabIndex = 9;
            // 
            // rdTypeCbx
            // 
            this.rdTypeCbx.FormattingEnabled = true;
            this.rdTypeCbx.Location = new System.Drawing.Point(172, 92);
            this.rdTypeCbx.Name = "rdTypeCbx";
            this.rdTypeCbx.Size = new System.Drawing.Size(139, 20);
            this.rdTypeCbx.TabIndex = 17;
            // 
            // EditReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 327);
            this.Controls.Add(this.rdTypeCbx);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdBorrovQtyTB);
            this.Controls.Add(this.rdQQTB);
            this.Controls.Add(this.rdDeptTB);
            this.Controls.Add(this.rdNameTB);
            this.Controls.Add(this.rdIDTB);
            this.Name = "EditReaderForm";
            this.Text = "EditReaderForm";
            this.Load += new System.EventHandler(this.EditReaderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rdBorrovQtyTB;
        private System.Windows.Forms.TextBox rdQQTB;
        private System.Windows.Forms.TextBox rdDeptTB;
        private System.Windows.Forms.TextBox rdNameTB;
        private System.Windows.Forms.TextBox rdIDTB;
        private System.Windows.Forms.ComboBox rdTypeCbx;
    }
}