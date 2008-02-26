namespace PromoGuru
{
    partial class SupplierForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.ListBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.txtSla = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.ComboBox();
            this.activeCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact\'s Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact\'s Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SLA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Registered Products:";
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(12, 260);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(286, 95);
            this.productList.TabIndex = 7;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(137, 49);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(161, 20);
            this.txtCompanyName.TabIndex = 9;
            this.txtCompanyName.Leave += new System.EventHandler(this.CompanyNameBox_Leave);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(137, 84);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(161, 20);
            this.txtContact.TabIndex = 10;
            this.txtContact.Leave += new System.EventHandler(this.contactNameBox_Leave);
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(188, 119);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(110, 20);
            this.txtContactNum.TabIndex = 11;
            this.txtContactNum.Leave += new System.EventHandler(this.phoneBox_Leave);
            // 
            // txtSla
            // 
            this.txtSla.Location = new System.Drawing.Point(137, 154);
            this.txtSla.Name = "txtSla";
            this.txtSla.Size = new System.Drawing.Size(161, 20);
            this.txtSla.TabIndex = 12;
            this.txtSla.Leave += new System.EventHandler(this.slaBox_Leave);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 362);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 15;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(101, 362);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(47, 23);
            this.newButton.TabIndex = 16;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(251, 362);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(46, 23);
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(162, 362);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add Product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idBox
            // 
            this.idBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idBox.FormattingEnabled = true;
            this.idBox.Location = new System.Drawing.Point(198, 15);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 21);
            this.idBox.Sorted = true;
            this.idBox.TabIndex = 20;
            this.idBox.SelectedIndexChanged += new System.EventHandler(this.idBox_SelectedIndexChanged);
            // 
            // activeCheck
            // 
            this.activeCheck.AutoSize = true;
            this.activeCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activeCheck.Location = new System.Drawing.Point(10, 194);
            this.activeCheck.Name = "activeCheck";
            this.activeCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.activeCheck.Size = new System.Drawing.Size(141, 17);
            this.activeCheck.TabIndex = 21;
            this.activeCheck.Text = "Supplier is still active:     ";
            this.activeCheck.UseVisualStyleBackColor = true;
            this.activeCheck.CheckedChanged += new System.EventHandler(this.activeCheck_CheckedChanged);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 405);
            this.ControlBox = false;
            this.Controls.Add(this.activeCheck);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.txtSla);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SupplierForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supplier Manager";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.TextBox txtSla;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.ComboBox idBox;
        private System.Windows.Forms.CheckBox activeCheck;
    }
}