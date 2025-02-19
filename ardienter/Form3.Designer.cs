using System;

namespace ardienter
{
    partial class Form3
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
            this.listBoxReceipt = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelDiscountedAmount = new System.Windows.Forms.Label();
            this.labelFinalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxReceipt
            // 
            this.listBoxReceipt.BackColor = System.Drawing.Color.White;
            this.listBoxReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxReceipt.FormattingEnabled = true;
            this.listBoxReceipt.Location = new System.Drawing.Point(27, 101);
            this.listBoxReceipt.Name = "listBoxReceipt";
            this.listBoxReceipt.Size = new System.Drawing.Size(246, 156);
            this.listBoxReceipt.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Location = new System.Drawing.Point(150, 260);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(35, 13);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "label1";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Location = new System.Drawing.Point(150, 273);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(35, 13);
            this.labelDiscount.TabIndex = 2;
            this.labelDiscount.Text = "label1";
            // 
            // labelDiscountedAmount
            // 
            this.labelDiscountedAmount.AutoSize = true;
            this.labelDiscountedAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscountedAmount.Location = new System.Drawing.Point(150, 286);
            this.labelDiscountedAmount.Name = "labelDiscountedAmount";
            this.labelDiscountedAmount.Size = new System.Drawing.Size(35, 13);
            this.labelDiscountedAmount.TabIndex = 3;
            this.labelDiscountedAmount.Text = "label1";
            // 
            // labelFinalAmount
            // 
            this.labelFinalAmount.AutoSize = true;
            this.labelFinalAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelFinalAmount.Location = new System.Drawing.Point(150, 299);
            this.labelFinalAmount.Name = "labelFinalAmount";
            this.labelFinalAmount.Size = new System.Drawing.Size(35, 13);
            this.labelFinalAmount.TabIndex = 4;
            this.labelFinalAmount.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "THANK YOU FOR SHOPPING!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ARDIENTE CAPITAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(106, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OFFICIAL RECEIPT";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ardienter.Properties.Resources.receipt1;
            this.ClientSize = new System.Drawing.Size(296, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFinalAmount);
            this.Controls.Add(this.labelDiscountedAmount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxReceipt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxReceipt;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelDiscountedAmount;
        private System.Windows.Forms.Label labelFinalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}