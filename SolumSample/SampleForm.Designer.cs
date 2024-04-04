namespace SoulumSample
{
    partial class SampleForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.Details1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ItemValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.Logo1 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Store = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.URL2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Details1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(673, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 137;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Details1
            // 
            this.Details1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Details1.Controls.Add(this.button1);
            this.Details1.Controls.Add(this.ItemDescription);
            this.Details1.Controls.Add(this.label9);
            this.Details1.Controls.Add(this.ItemValue);
            this.Details1.Controls.Add(this.label5);
            this.Details1.Controls.Add(this.ItemID);
            this.Details1.Controls.Add(this.label1);
            this.Details1.Controls.Add(this.buttonTest);
            this.Details1.Controls.Add(this.Logo1);
            this.Details1.Controls.Add(this.Password);
            this.Details1.Controls.Add(this.Store);
            this.Details1.Controls.Add(this.label8);
            this.Details1.Controls.Add(this.Company);
            this.Details1.Controls.Add(this.label7);
            this.Details1.Controls.Add(this.User);
            this.Details1.Controls.Add(this.label6);
            this.Details1.Controls.Add(this.URL2);
            this.Details1.Controls.Add(this.label4);
            this.Details1.Controls.Add(this.label3);
            this.Details1.Controls.Add(this.URL);
            this.Details1.Controls.Add(this.label2);
            this.Details1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Details1.Location = new System.Drawing.Point(0, 0);
            this.Details1.Name = "Details1";
            this.Details1.Size = new System.Drawing.Size(814, 220);
            this.Details1.TabIndex = 136;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(673, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 134;
            this.button1.Text = "Upload >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemDescription
            // 
            this.ItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ItemDescription.Location = new System.Drawing.Point(306, 177);
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Size = new System.Drawing.Size(187, 20);
            this.ItemDescription.TabIndex = 132;
            this.ItemDescription.Text = "Item A0001 Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(206, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 133;
            this.label9.Text = "Item Description:";
            // 
            // ItemValue
            // 
            this.ItemValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ItemValue.Location = new System.Drawing.Point(562, 177);
            this.ItemValue.Name = "ItemValue";
            this.ItemValue.Size = new System.Drawing.Size(68, 20);
            this.ItemValue.TabIndex = 130;
            this.ItemValue.Text = "1,00";
            this.ItemValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(499, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 131;
            this.label5.Text = "Item Price:";
            // 
            // ItemID
            // 
            this.ItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ItemID.Location = new System.Drawing.Point(124, 177);
            this.ItemID.Name = "ItemID";
            this.ItemID.Size = new System.Drawing.Size(68, 20);
            this.ItemID.TabIndex = 128;
            this.ItemID.Text = "A00001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(24, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Item ID:";
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.Location = new System.Drawing.Point(673, 87);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(105, 23);
            this.buttonTest.TabIndex = 127;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Logo1
            // 
            this.Logo1.Image = global::SolumSample.Properties.Resources.solum_logo;
            this.Logo1.Location = new System.Drawing.Point(506, 9);
            this.Logo1.Name = "Logo1";
            this.Logo1.Size = new System.Drawing.Size(272, 67);
            this.Logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo1.TabIndex = 120;
            this.Logo1.TabStop = false;
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Password.Location = new System.Drawing.Point(477, 89);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(154, 20);
            this.Password.TabIndex = 3;
            // 
            // Store
            // 
            this.Store.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Store.Location = new System.Drawing.Point(305, 122);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(68, 20);
            this.Store.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(259, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "Store:";
            // 
            // Company
            // 
            this.Company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Company.Location = new System.Drawing.Point(124, 122);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(68, 20);
            this.Company.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(24, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "Company:";
            // 
            // User
            // 
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.User.Location = new System.Drawing.Point(124, 89);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(250, 20);
            this.User.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(24, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "User:";
            // 
            // URL2
            // 
            this.URL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.URL2.Location = new System.Drawing.Point(124, 56);
            this.URL2.Name = "URL2";
            this.URL2.Size = new System.Drawing.Size(359, 20);
            this.URL2.TabIndex = 1;
            this.URL2.Text = "https://eu.common.solumesl.com/common/api/v2/common/articles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(24, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "URL Itens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(417, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Password:";
            // 
            // URL
            // 
            this.URL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.URL.Location = new System.Drawing.Point(124, 23);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(359, 20);
            this.URL.TabIndex = 0;
            this.URL.Text = "https://eu.common.solumesl.com/common/api/v2/token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "URL Login:";
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(814, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Details1);
            this.Name = "SampleForm";
            this.Text = "Solum Sample";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            this.Details1.ResumeLayout(false);
            this.Details1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Details1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ItemDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ItemValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.PictureBox Logo1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Store;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox URL2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label label2;
    }
}

