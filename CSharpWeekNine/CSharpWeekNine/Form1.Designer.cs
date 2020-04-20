namespace CSharpWeekNine
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.beginButton = new System.Windows.Forms.Button();
            this.conditionPanel = new System.Windows.Forms.Panel();
            this.QueryButton = new System.Windows.Forms.Button();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.baseUrlTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UrlInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.UrlInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.successDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrlInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(556, 14);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(97, 37);
            this.beginButton.TabIndex = 0;
            this.beginButton.Text = "开始";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // conditionPanel
            // 
            this.conditionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conditionPanel.Controls.Add(this.QueryButton);
            this.conditionPanel.Controls.Add(this.conditionComboBox);
            this.conditionPanel.Controls.Add(this.baseUrlTextBox);
            this.conditionPanel.Controls.Add(this.beginButton);
            this.conditionPanel.Location = new System.Drawing.Point(12, 12);
            this.conditionPanel.Name = "conditionPanel";
            this.conditionPanel.Size = new System.Drawing.Size(785, 162);
            this.conditionPanel.TabIndex = 1;
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(556, 79);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(97, 34);
            this.QueryButton.TabIndex = 3;
            this.QueryButton.Text = "查询";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Items.AddRange(new object[] {
            "全部",
            "成功",
            "失败"});
            this.conditionComboBox.Location = new System.Drawing.Point(376, 79);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(121, 26);
            this.conditionComboBox.TabIndex = 2;
            // 
            // baseUrlTextBox
            // 
            this.baseUrlTextBox.Location = new System.Drawing.Point(94, 14);
            this.baseUrlTextBox.Name = "baseUrlTextBox";
            this.baseUrlTextBox.Size = new System.Drawing.Size(403, 28);
            this.baseUrlTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.UrlInfoDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 223);
            this.panel1.TabIndex = 2;
            // 
            // UrlInfoDataGridView
            // 
            this.UrlInfoDataGridView.AutoGenerateColumns = false;
            this.UrlInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrlInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn,
            this.successDataGridViewTextBoxColumn});
            this.UrlInfoDataGridView.DataSource = this.UrlInfoBindingSource;
            this.UrlInfoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.UrlInfoDataGridView.Name = "UrlInfoDataGridView";
            this.UrlInfoDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UrlInfoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UrlInfoDataGridView.RowTemplate.Height = 30;
            this.UrlInfoDataGridView.Size = new System.Drawing.Size(738, 264);
            this.UrlInfoDataGridView.TabIndex = 0;
            // 
            // UrlInfoBindingSource
            // 
            this.UrlInfoBindingSource.DataSource = typeof(CSharpWeekNine.UrlInfo);
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.urlDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Width = 300;
            // 
            // successDataGridViewTextBoxColumn
            // 
            this.successDataGridViewTextBoxColumn.DataPropertyName = "Success";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.successDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.successDataGridViewTextBoxColumn.HeaderText = "爬取状态";
            this.successDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.successDataGridViewTextBoxColumn.Name = "successDataGridViewTextBoxColumn";
            this.successDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.conditionPanel);
            this.Name = "Form1";
            this.Text = "爬虫模拟系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.conditionPanel.ResumeLayout(false);
            this.conditionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UrlInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Panel conditionPanel;
        private System.Windows.Forms.TextBox baseUrlTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource UrlInfoBindingSource;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.DataGridView UrlInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn successDataGridViewTextBoxColumn;
    }
}

