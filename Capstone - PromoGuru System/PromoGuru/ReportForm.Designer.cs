namespace PromoGuru
{
    partial class ReportForm
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
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnUnsent = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(13, 13);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(267, 23);
            this.btnWeek.TabIndex = 0;
            this.btnWeek.Text = "Show Sales for the week";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(13, 42);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(267, 23);
            this.btnMonth.TabIndex = 1;
            this.btnMonth.Text = "Show Sales for the month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnUnsent
            // 
            this.btnUnsent.Location = new System.Drawing.Point(13, 72);
            this.btnUnsent.Name = "btnUnsent";
            this.btnUnsent.Size = new System.Drawing.Size(267, 23);
            this.btnUnsent.TabIndex = 2;
            this.btnUnsent.Text = "Show Unsent shipments";
            this.btnUnsent.UseVisualStyleBackColor = true;
            this.btnUnsent.Click += new System.EventHandler(this.btnUnsent_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(13, 102);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResult.Size = new System.Drawing.Size(267, 273);
            this.txtResult.TabIndex = 3;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 387);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnUnsent);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnWeek);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnUnsent;
        private System.Windows.Forms.TextBox txtResult;
    }
}