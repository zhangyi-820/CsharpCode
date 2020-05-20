namespace OrderGUISystem
{
    partial class AddOrderForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createButton = new System.Windows.Forms.Button();
            this.recAddressTextBox = new System.Windows.Forms.TextBox();
            this.receivingAddressLabel = new System.Windows.Forms.Label();
            this.receivingPersonLabel = new System.Windows.Forms.Label();
            this.recPersonTextBox = new System.Windows.Forms.TextBox();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productAmountTextBox = new System.Windows.Forms.TextBox();
            this.goodsIDLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.Controls.Add(this.createButton);
            this.mainPanel.Controls.Add(this.recAddressTextBox);
            this.mainPanel.Controls.Add(this.receivingAddressLabel);
            this.mainPanel.Controls.Add(this.receivingPersonLabel);
            this.mainPanel.Controls.Add(this.recPersonTextBox);
            this.mainPanel.Location = new System.Drawing.Point(32, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(701, 143);
            this.mainPanel.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createButton.Location = new System.Drawing.Point(519, 50);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(87, 38);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "创建";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // recAddressTextBox
            // 
            this.recAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recAddressTextBox.Location = new System.Drawing.Point(196, 90);
            this.recAddressTextBox.Name = "recAddressTextBox";
            this.recAddressTextBox.Size = new System.Drawing.Size(212, 28);
            this.recAddressTextBox.TabIndex = 1;
            // 
            // receivingAddressLabel
            // 
            this.receivingAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.receivingAddressLabel.AutoSize = true;
            this.receivingAddressLabel.Location = new System.Drawing.Point(21, 100);
            this.receivingAddressLabel.Name = "receivingAddressLabel";
            this.receivingAddressLabel.Size = new System.Drawing.Size(80, 18);
            this.receivingAddressLabel.TabIndex = 2;
            this.receivingAddressLabel.Text = "收货地址";
            // 
            // receivingPersonLabel
            // 
            this.receivingPersonLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.receivingPersonLabel.AutoSize = true;
            this.receivingPersonLabel.Location = new System.Drawing.Point(21, 38);
            this.receivingPersonLabel.Name = "receivingPersonLabel";
            this.receivingPersonLabel.Size = new System.Drawing.Size(62, 18);
            this.receivingPersonLabel.TabIndex = 1;
            this.receivingPersonLabel.Text = "收货人";
            // 
            // recPersonTextBox
            // 
            this.recPersonTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recPersonTextBox.Location = new System.Drawing.Point(196, 28);
            this.recPersonTextBox.Name = "recPersonTextBox";
            this.recPersonTextBox.Size = new System.Drawing.Size(212, 28);
            this.recPersonTextBox.TabIndex = 0;
            // 
            // addPanel
            // 
            this.addPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPanel.Controls.Add(this.addButton);
            this.addPanel.Controls.Add(this.productPriceTextBox);
            this.addPanel.Controls.Add(this.productIdTextBox);
            this.addPanel.Controls.Add(this.productAmountTextBox);
            this.addPanel.Controls.Add(this.goodsIDLabel);
            this.addPanel.Controls.Add(this.priceLabel);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.goodsNameLabel);
            this.addPanel.Controls.Add(this.productNameTextBox);
            this.addPanel.Location = new System.Drawing.Point(32, 178);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(701, 199);
            this.addPanel.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Location = new System.Drawing.Point(277, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 36);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "添加商品";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(168, 92);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(100, 28);
            this.productPriceTextBox.TabIndex = 5;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(489, 32);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 28);
            this.productIdTextBox.TabIndex = 4;
            // 
            // productAmountTextBox
            // 
            this.productAmountTextBox.Location = new System.Drawing.Point(489, 92);
            this.productAmountTextBox.Name = "productAmountTextBox";
            this.productAmountTextBox.Size = new System.Drawing.Size(100, 28);
            this.productAmountTextBox.TabIndex = 6;
            // 
            // goodsIDLabel
            // 
            this.goodsIDLabel.AutoSize = true;
            this.goodsIDLabel.Location = new System.Drawing.Point(368, 35);
            this.goodsIDLabel.Name = "goodsIDLabel";
            this.goodsIDLabel.Size = new System.Drawing.Size(80, 18);
            this.goodsIDLabel.TabIndex = 5;
            this.goodsIDLabel.Text = "商品编号";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(42, 95);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(80, 18);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "商品单价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品数量";
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Location = new System.Drawing.Point(42, 28);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(80, 18);
            this.goodsNameLabel.TabIndex = 1;
            this.goodsNameLabel.Text = "商品名称";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(168, 25);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 28);
            this.productNameTextBox.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(309, 402);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 36);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox recAddressTextBox;
        private System.Windows.Forms.Label receivingAddressLabel;
        private System.Windows.Forms.Label receivingPersonLabel;
        private System.Windows.Forms.TextBox recPersonTextBox;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox productAmountTextBox;
        private System.Windows.Forms.Label goodsIDLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Button backButton;
    }
}