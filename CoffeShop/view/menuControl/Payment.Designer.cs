namespace CoffeeShop.view.menuControl
{
    partial class Payment
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.btnPaymentMade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 23);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(116, 20);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount to pay:";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(12, 71);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(133, 20);
            this.lblPaymentAmount.TabIndex = 1;
            this.lblPaymentAmount.Text = "Payment amount:";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(151, 20);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(242, 26);
            this.txtAmountToPay.TabIndex = 2;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(151, 68);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(242, 26);
            this.txtPaymentAmount.TabIndex = 3;
            // 
            // btnPaymentMade
            // 
            this.btnPaymentMade.Location = new System.Drawing.Point(115, 115);
            this.btnPaymentMade.Name = "btnPaymentMade";
            this.btnPaymentMade.Size = new System.Drawing.Size(184, 38);
            this.btnPaymentMade.TabIndex = 4;
            this.btnPaymentMade.Text = "Payment made";
            this.btnPaymentMade.UseVisualStyleBackColor = true;
            this.btnPaymentMade.Click += new System.EventHandler(this.PaymentHasBeenMade);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 178);
            this.Controls.Add(this.btnPaymentMade);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Button btnPaymentMade;
    }
}