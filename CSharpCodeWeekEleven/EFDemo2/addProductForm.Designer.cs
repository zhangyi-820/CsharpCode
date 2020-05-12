namespace OrderGUISystem
{
    partial class addProductForm
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.productIdtextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(24, 68);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(80, 18);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "商品名称";
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(24, 134);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(80, 18);
            this.productIdLabel.TabIndex = 1;
            this.productIdLabel.Text = "商品编号";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(24, 205);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(80, 18);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "商品单价";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(24, 275);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(80, 18);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "商品数量";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(152, 65);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 28);
            this.productNameTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(152, 205);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 28);
            this.priceTextBox.TabIndex = 5;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(152, 275);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 28);
            this.amountTextBox.TabIndex = 6;
            // 
            // productIdtextBox
            // 
            this.productIdtextBox.Location = new System.Drawing.Point(152, 134);
            this.productIdtextBox.Name = "productIdtextBox";
            this.productIdtextBox.Size = new System.Drawing.Size(100, 28);
            this.productIdtextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(90, 352);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 37);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // addProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productIdtextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productNameLabel);
            this.Name = "addProductForm";
            this.Text = "添加商品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox productIdtextBox;
        private System.Windows.Forms.Button addButton;
    }
}