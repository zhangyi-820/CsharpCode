namespace OrderGUISystem
{
    partial class alterForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.alterButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.productBindingSource_1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.alterProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.RecAddressTextBox = new System.Windows.Forms.TextBox();
            this.RecPersonTextBox = new System.Windows.Forms.TextBox();
            this.RecAddlabel = new System.Windows.Forms.Label();
            this.RecPerLabel = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource_1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alterButton
            // 
            this.alterButton.Location = new System.Drawing.Point(261, 34);
            this.alterButton.Name = "alterButton";
            this.alterButton.Size = new System.Drawing.Size(103, 38);
            this.alterButton.TabIndex = 0;
            this.alterButton.Text = "修改";
            this.alterButton.UseVisualStyleBackColor = true;
            this.alterButton.Click += new System.EventHandler(this.alterButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.productDataGridView);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(912, 434);
            this.mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteProductButton);
            this.panel1.Controls.Add(this.alterProductButton);
            this.panel1.Controls.Add(this.addProductButton);
            this.panel1.Controls.Add(this.RecAddressTextBox);
            this.panel1.Controls.Add(this.RecPersonTextBox);
            this.panel1.Controls.Add(this.RecAddlabel);
            this.panel1.Controls.Add(this.RecPerLabel);
            this.panel1.Controls.Add(this.alterButton);
            this.panel1.Location = new System.Drawing.Point(22, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 137);
            this.panel1.TabIndex = 2;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(637, 34);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(103, 38);
            this.deleteProductButton.TabIndex = 7;
            this.deleteProductButton.Text = "删除商品";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // alterProductButton
            // 
            this.alterProductButton.Location = new System.Drawing.Point(510, 34);
            this.alterProductButton.Name = "alterProductButton";
            this.alterProductButton.Size = new System.Drawing.Size(103, 38);
            this.alterProductButton.TabIndex = 6;
            this.alterProductButton.Text = "修改商品";
            this.alterProductButton.UseVisualStyleBackColor = true;
            this.alterProductButton.Click += new System.EventHandler(this.alterProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(387, 34);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(103, 38);
            this.addProductButton.TabIndex = 5;
            this.addProductButton.Text = "添加商品";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // RecAddressTextBox
            // 
            this.RecAddressTextBox.Location = new System.Drawing.Point(123, 67);
            this.RecAddressTextBox.Name = "RecAddressTextBox";
            this.RecAddressTextBox.Size = new System.Drawing.Size(100, 28);
            this.RecAddressTextBox.TabIndex = 4;
            // 
            // RecPersonTextBox
            // 
            this.RecPersonTextBox.Location = new System.Drawing.Point(123, 19);
            this.RecPersonTextBox.Name = "RecPersonTextBox";
            this.RecPersonTextBox.Size = new System.Drawing.Size(100, 28);
            this.RecPersonTextBox.TabIndex = 3;
            // 
            // RecAddlabel
            // 
            this.RecAddlabel.AutoSize = true;
            this.RecAddlabel.Location = new System.Drawing.Point(13, 77);
            this.RecAddlabel.Name = "RecAddlabel";
            this.RecAddlabel.Size = new System.Drawing.Size(80, 18);
            this.RecAddlabel.TabIndex = 2;
            this.RecAddlabel.Text = "收货地址";
            // 
            // RecPerLabel
            // 
            this.RecPerLabel.AutoSize = true;
            this.RecPerLabel.Location = new System.Drawing.Point(13, 22);
            this.RecPerLabel.Name = "RecPerLabel";
            this.RecPerLabel.Size = new System.Drawing.Size(62, 18);
            this.RecPerLabel.TabIndex = 1;
            this.RecPerLabel.Text = "收货人";
            // 
            // productDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(22, 163);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.productDataGridView.RowTemplate.Height = 30;
            this.productDataGridView.Size = new System.Drawing.Size(887, 293);
            this.productDataGridView.TabIndex = 5;
            // 
            // alterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "alterForm";
            this.Text = "修改订单信息";
            this.Load += new System.EventHandler(this.alterForm_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button alterButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button alterProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox RecAddressTextBox;
        private System.Windows.Forms.TextBox RecPersonTextBox;
        private System.Windows.Forms.Label RecAddlabel;
        private System.Windows.Forms.Label RecPerLabel;
        private System.Windows.Forms.BindingSource productBindingSource_1;
        private System.Windows.Forms.DataGridView productDataGridView;
    }
}