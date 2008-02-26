namespace PromoGuru
{
    partial class OrderForm
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
            this.dropDate = new System.Windows.Forms.DateTimePicker();
            this.dropShipped = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbOrderId = new System.Windows.Forms.ComboBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lstQuantities = new System.Windows.Forms.ListBox();
            this.lstProductIds = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmsQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmsQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custmer Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Taken:";
            // 
            // dropDate
            // 
            this.dropDate.Location = new System.Drawing.Point(124, 83);
            this.dropDate.Name = "dropDate";
            this.dropDate.Size = new System.Drawing.Size(169, 20);
            this.dropDate.TabIndex = 5;
            this.dropDate.ValueChanged += new System.EventHandler(this.dropDate_ValueChanged);
            // 
            // dropShipped
            // 
            this.dropShipped.Location = new System.Drawing.Point(124, 120);
            this.dropShipped.Name = "dropShipped";
            this.dropShipped.Size = new System.Drawing.Size(169, 20);
            this.dropShipped.TabIndex = 6;
            this.dropShipped.ValueChanged += new System.EventHandler(this.dropShipped_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date Shipped:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Items:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 298);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(93, 298);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(149, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(230, 298);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbOrderId
            // 
            this.cmbOrderId.FormattingEnabled = true;
            this.cmbOrderId.Location = new System.Drawing.Point(172, 15);
            this.cmbOrderId.Name = "cmbOrderId";
            this.cmbOrderId.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderId.TabIndex = 14;
            this.cmbOrderId.Text = "1";
            this.cmbOrderId.SelectedIndexChanged += new System.EventHandler(this.cmbOrderId_SelectedIndexChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(172, 46);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerID.TabIndex = 15;
            // 
            // lstQuantities
            // 
            this.lstQuantities.FormattingEnabled = true;
            this.lstQuantities.Location = new System.Drawing.Point(93, 192);
            this.lstQuantities.Name = "lstQuantities";
            this.lstQuantities.Size = new System.Drawing.Size(64, 95);
            this.lstQuantities.TabIndex = 16;
            // 
            // lstProductIds
            // 
            this.lstProductIds.FormattingEnabled = true;
            this.lstProductIds.Location = new System.Drawing.Point(16, 192);
            this.lstProductIds.Name = "lstProductIds";
            this.lstProductIds.Size = new System.Drawing.Size(64, 95);
            this.lstProductIds.TabIndex = 17;
            this.lstProductIds.SelectedIndexChanged += new System.EventHandler(this.lstProductIds_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Edit Current Quanitity:";
            // 
            // nmsQuantity
            // 
            this.nmsQuantity.Location = new System.Drawing.Point(172, 220);
            this.nmsQuantity.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nmsQuantity.Name = "nmsQuantity";
            this.nmsQuantity.Size = new System.Drawing.Size(109, 20);
            this.nmsQuantity.TabIndex = 19;
            this.nmsQuantity.ValueChanged += new System.EventHandler(this.nmsQuantity_ValueChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 340);
            this.Controls.Add(this.nmsQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstProductIds);
            this.Controls.Add(this.lstQuantities);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.cmbOrderId);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropShipped);
            this.Controls.Add(this.dropDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmsQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dropDate;
        private System.Windows.Forms.DateTimePicker dropShipped;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbOrderId;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ListBox lstQuantities;
        private System.Windows.Forms.ListBox lstProductIds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmsQuantity;
    }
}