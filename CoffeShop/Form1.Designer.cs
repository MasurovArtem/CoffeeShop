namespace CoffeeShop
{
    partial class Form1
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenPOS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bthOpenGraph = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(6, 25);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(400, 39);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(6, 79);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(400, 39);
            this.btnViewProducts.TabIndex = 1;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenPOS);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.btnViewProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // btnOpenPOS
            // 
            this.btnOpenPOS.Location = new System.Drawing.Point(6, 134);
            this.btnOpenPOS.Name = "btnOpenPOS";
            this.btnOpenPOS.Size = new System.Drawing.Size(400, 39);
            this.btnOpenPOS.TabIndex = 2;
            this.btnOpenPOS.Text = "Open POS";
            this.btnOpenPOS.UseVisualStyleBackColor = true;
            this.btnOpenPOS.Click += new System.EventHandler(this.btnOpenPOS_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bthOpenGraph);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start system";
            // 
            // bthOpenGraph
            // 
            this.bthOpenGraph.Location = new System.Drawing.Point(6, 30);
            this.bthOpenGraph.Name = "bthOpenGraph";
            this.bthOpenGraph.Size = new System.Drawing.Size(400, 39);
            this.bthOpenGraph.TabIndex = 3;
            this.bthOpenGraph.Text = "Open Till";
            this.bthOpenGraph.UseVisualStyleBackColor = true;
            this.bthOpenGraph.Click += new System.EventHandler(this.bthOpenGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CoffeeShop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenPOS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bthOpenGraph;
    }
}

