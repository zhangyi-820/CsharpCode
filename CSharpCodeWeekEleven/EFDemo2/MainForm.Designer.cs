namespace OrderGUISystem
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.inquireButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.orderItemPanel = new System.Windows.Forms.Panel();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.orderItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(496, 31);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 32);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "返回/刷新";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conditionTextBox.Location = new System.Drawing.Point(218, 35);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(111, 28);
            this.conditionTextBox.TabIndex = 8;
            // 
            // orderDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(3, 124);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDataGridView.RowTemplate.Height = 30;
            this.orderDataGridView.Size = new System.Drawing.Size(618, 293);
            this.orderDataGridView.TabIndex = 7;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // importButton
            // 
            this.importButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importButton.Location = new System.Drawing.Point(389, 83);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(104, 35);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "恢复数据";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportButton.Location = new System.Drawing.Point(259, 83);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(104, 35);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "备份数据";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.Location = new System.Drawing.Point(127, 83);
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
            this.modifyButton.Location = new System.Drawing.Point(517, 83);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(104, 35);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "修改订单";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // inquireButton
            // 
            this.inquireButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inquireButton.Location = new System.Drawing.Point(375, 35);
            this.inquireButton.Name = "inquireButton";
            this.inquireButton.Size = new System.Drawing.Size(75, 32);
            this.inquireButton.TabIndex = 0;
            this.inquireButton.Text = "查询";
            this.inquireButton.UseVisualStyleBackColor = true;
            this.inquireButton.Click += new System.EventHandler(this.inquireButton_Click);
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
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
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
            this.conditionComboBox.Location = new System.Drawing.Point(69, 35);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(121, 26);
            this.conditionComboBox.TabIndex = 1;
            // 
            // orderItemPanel
            // 
            this.orderItemPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderItemPanel.Controls.Add(this.productDataGridView);
            this.orderItemPanel.Location = new System.Drawing.Point(690, 12);
            this.orderItemPanel.Name = "orderItemPanel";
            this.orderItemPanel.Size = new System.Drawing.Size(591, 443);
            this.orderItemPanel.TabIndex = 6;
            // 
            // productDataGridView
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.productDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(3, 124);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.productDataGridView.RowTemplate.Height = 30;
            this.productDataGridView.Size = new System.Drawing.Size(611, 293);
            this.productDataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 450);
            this.Controls.Add(this.orderItemPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.orderItemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button inquireButton;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.Panel orderItemPanel;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}