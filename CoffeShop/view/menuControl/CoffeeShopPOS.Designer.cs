namespace CoffeeShop.view.menuControl
{
    partial class CoffeeShopPOS
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
            this.lstProductsChoosen = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtInfopanel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstProductsChoosen
            // 
            this.lstProductsChoosen.Font = new System.Drawing.Font("Courier New", 8F);
            this.lstProductsChoosen.FormattingEnabled = true;
            this.lstProductsChoosen.ItemHeight = 18;
            this.lstProductsChoosen.Location = new System.Drawing.Point(577, 12);
            this.lstProductsChoosen.Name = "lstProductsChoosen";
            this.lstProductsChoosen.Size = new System.Drawing.Size(401, 436);
            this.lstProductsChoosen.TabIndex = 0;
            this.lstProductsChoosen.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListItem);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(13, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 404);
            this.tabControl1.TabIndex = 2;
            // 
            // txtInfopanel
            // 
            this.txtInfopanel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfopanel.Location = new System.Drawing.Point(13, 13);
            this.txtInfopanel.Name = "txtInfopanel";
            this.txtInfopanel.Size = new System.Drawing.Size(558, 30);
            this.txtInfopanel.TabIndex = 3;
            this.txtInfopanel.Text = "Next customer";
            // 
            // CoffeeShopPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 575);
            this.Controls.Add(this.txtInfopanel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstProductsChoosen);
            this.Name = "CoffeeShopPOS";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductsChoosen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtInfopanel;
    }
}