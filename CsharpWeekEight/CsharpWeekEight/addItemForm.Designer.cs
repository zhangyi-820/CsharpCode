namespace CsharpWeekEight
{
    partial class addItemForm
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
            this.addPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.goodsPriceTextBox = new System.Windows.Forms.TextBox();
            this.goodsIDTextBox = new System.Windows.Forms.TextBox();
            this.goodsNumberTextBox = new System.Windows.Forms.TextBox();
            this.goodsIDLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.goodsNameTextBox = new System.Windows.Forms.TextBox();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPanel.Controls.Add(this.addButton);
            this.addPanel.Controls.Add(this.goodsPriceTextBox);
            this.addPanel.Controls.Add(this.goodsIDTextBox);
            this.addPanel.Controls.Add(this.goodsNumberTextBox);
            this.addPanel.Controls.Add(this.goodsIDLabel);
            this.addPanel.Controls.Add(this.priceLabel);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.goodsNameLabel);
            this.addPanel.Controls.Add(this.goodsNameTextBox);
            this.addPanel.Location = new System.Drawing.Point(6, 41);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(701, 217);
            this.addPanel.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Location = new System.Drawing.Point(277, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 36);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "添加商品";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // goodsPriceTextBox
            // 
            this.goodsPriceTextBox.Location = new System.Drawing.Point(168, 92);
            this.goodsPriceTextBox.Name = "goodsPriceTextBox";
            this.goodsPriceTextBox.Size = new System.Drawing.Size(100, 28);
            this.goodsPriceTextBox.TabIndex = 2;
            // 
            // goodsIDTextBox
            // 
            this.goodsIDTextBox.Location = new System.Drawing.Point(489, 32);
            this.goodsIDTextBox.Name = "goodsIDTextBox";
            this.goodsIDTextBox.Size = new System.Drawing.Size(100, 28);
            this.goodsIDTextBox.TabIndex = 1;
            // 
            // goodsNumberTextBox
            // 
            this.goodsNumberTextBox.Location = new System.Drawing.Point(489, 92);
            this.goodsNumberTextBox.Name = "goodsNumberTextBox";
            this.goodsNumberTextBox.Size = new System.Drawing.Size(100, 28);
            this.goodsNumberTextBox.TabIndex = 3;
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
            // goodsNameTextBox
            // 
            this.goodsNameTextBox.Location = new System.Drawing.Point(168, 25);
            this.goodsNameTextBox.Name = "goodsNameTextBox";
            this.goodsNameTextBox.Size = new System.Drawing.Size(100, 28);
            this.goodsNameTextBox.TabIndex = 0;
            // 
            // addItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 280);
            this.Controls.Add(this.addPanel);
            this.Name = "addItemForm";
            this.Text = "添加商品";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox goodsPriceTextBox;
        private System.Windows.Forms.TextBox goodsIDTextBox;
        private System.Windows.Forms.TextBox goodsNumberTextBox;
        private System.Windows.Forms.Label goodsIDLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.TextBox goodsNameTextBox;
    }
}