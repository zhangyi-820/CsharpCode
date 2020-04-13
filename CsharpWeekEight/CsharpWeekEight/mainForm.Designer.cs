namespace CsharpWeekEight
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inquireButton = new System.Windows.Forms.Button();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.orderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.orderItemPanel = new System.Windows.Forms.Panel();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivingPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).BeginInit();
            this.orderItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inquireButton
            // 
            this.inquireButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inquireButton.Location = new System.Drawing.Point(407, 35);
            this.inquireButton.Name = "inquireButton";
            this.inquireButton.Size = new System.Drawing.Size(75, 32);
            this.inquireButton.TabIndex = 0;
            this.inquireButton.Text = "查询";
            this.inquireButton.UseVisualStyleBackColor = true;
            this.inquireButton.Click += new System.EventHandler(this.inquireButton_Click);
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.ItemHeight = 18;
            this.conditionComboBox.Items.AddRange(new object[] {
            "收货人",
            "商品名",
            "订单号"});
            this.conditionComboBox.Location = new System.Drawing.Point(110, 35);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(121, 26);
            this.conditionComboBox.TabIndex = 1;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateOrderButton.Location = new System.Drawing.Point(3, 83);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(104, 35);
            this.CreateOrderButton.TabIndex = 2;
            this.CreateOrderButton.Text = "新建订单";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.conditionTextBox);
            this.panel1.Controls.Add(this.orderDataGridView);
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.inquireButton);
            this.panel1.Controls.Add(this.CreateOrderButton);
            this.panel1.Controls.Add(this.conditionComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 443);
            this.panel1.TabIndex = 3;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conditionTextBox.Location = new System.Drawing.Point(252, 33);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(111, 28);
            this.conditionTextBox.TabIndex = 8;
            // 
            // orderDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.totalSumDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.receivingAddressDataGridViewTextBoxColumn,
            this.receivingPersonDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(3, 124);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.orderDataGridView.RowTemplate.Height = 30;
            this.orderDataGridView.Size = new System.Drawing.Size(606, 293);
            this.orderDataGridView.TabIndex = 7;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick_1);
            // 
            // importButton
            // 
            this.importButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importButton.Location = new System.Drawing.Point(505, 83);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(104, 35);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "导入";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportButton.Location = new System.Drawing.Point(378, 83);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(104, 35);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "导出";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.Location = new System.Drawing.Point(252, 83);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 35);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "删除订单";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyButton.Location = new System.Drawing.Point(127, 83);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(104, 35);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "保存修改";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // orderItemDataGridView
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderItemDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.orderItemDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderItemDataGridView.AutoGenerateColumns = false;
            this.orderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderItemDataGridView.DataSource = this.orderItemBindingSource;
            this.orderItemDataGridView.Location = new System.Drawing.Point(3, 124);
            this.orderItemDataGridView.Name = "orderItemDataGridView";
            this.orderItemDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderItemDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.orderItemDataGridView.RowTemplate.Height = 30;
            this.orderItemDataGridView.Size = new System.Drawing.Size(611, 293);
            this.orderItemDataGridView.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(522, 35);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 32);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // orderItemPanel
            // 
            this.orderItemPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderItemPanel.Controls.Add(this.deleteItemButton);
            this.orderItemPanel.Controls.Add(this.addItemButton);
            this.orderItemPanel.Controls.Add(this.orderItemDataGridView);
            this.orderItemPanel.Location = new System.Drawing.Point(691, 12);
            this.orderItemPanel.Name = "orderItemPanel";
            this.orderItemPanel.Size = new System.Drawing.Size(591, 443);
            this.orderItemPanel.TabIndex = 5;
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItemButton.Location = new System.Drawing.Point(66, 35);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(99, 33);
            this.addItemButton.TabIndex = 5;
            this.addItemButton.Text = "添加商品";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteItemButton.Location = new System.Drawing.Point(200, 33);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(96, 35);
            this.deleteItemButton.TabIndex = 6;
            this.deleteItemButton.Text = "删除商品";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.goodsIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.goodsIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            this.goodsIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.amountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.totalPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(CsharpWeekEight.OrderItem);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            this.totalSumDataGridViewTextBoxColumn.DataPropertyName = "TotalSum";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.totalSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalSumDataGridViewTextBoxColumn.HeaderText = "订单金额";
            this.totalSumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            this.totalSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSumDataGridViewTextBoxColumn.Width = 120;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.timeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.timeDataGridViewTextBoxColumn.HeaderText = "生成时间";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 120;
            // 
            // receivingAddressDataGridViewTextBoxColumn
            // 
            this.receivingAddressDataGridViewTextBoxColumn.DataPropertyName = "ReceivingAddress";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.receivingAddressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.receivingAddressDataGridViewTextBoxColumn.HeaderText = "收货地址";
            this.receivingAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.receivingAddressDataGridViewTextBoxColumn.Name = "receivingAddressDataGridViewTextBoxColumn";
            this.receivingAddressDataGridViewTextBoxColumn.Width = 120;
            // 
            // receivingPersonDataGridViewTextBoxColumn
            // 
            this.receivingPersonDataGridViewTextBoxColumn.DataPropertyName = "ReceivingPerson";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.receivingPersonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.receivingPersonDataGridViewTextBoxColumn.HeaderText = "收货人";
            this.receivingPersonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.receivingPersonDataGridViewTextBoxColumn.Name = "receivingPersonDataGridViewTextBoxColumn";
            this.receivingPersonDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(CsharpWeekEight.Order);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 481);
            this.Controls.Add(this.orderItemPanel);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).EndInit();
            this.orderItemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inquireButton;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.DataGridView orderItemDataGridView;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel orderItemPanel;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivingPersonDataGridViewTextBoxColumn;
    }
}

