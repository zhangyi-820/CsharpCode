using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWeekNine
{
    public partial class Form1 : Form
    {
        SimpleCrawler crawler;
        public Form1()
        {
            InitializeComponent();
            this.crawler = new SimpleCrawler();
            this.UrlInfoBindingSource.DataSource = this.crawler.UrlInfos;
            this.UrlInfoDataGridView.DataSource = this.UrlInfoBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void beginButton_Click(object sender,EventArgs e)
        {
            if (this.baseUrlTextBox.Text == "")
            {
                MessageBox.Show("请输入url", "ERROR", MessageBoxButtons.OK);
                return;
            }
            this.crawler.Begin(this.baseUrlTextBox.Text,this.UrlInfoBindingSource);
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            switch (conditionComboBox.SelectedIndex)
            {
                case 0:
                    this.UrlInfoBindingSource.DataSource = this.crawler.UrlInfos;
                    break;
                case 1:
                    this.UrlInfoBindingSource.DataSource = crawler.Query(true);
                    break;
                case 2:
                    this.UrlInfoBindingSource.DataSource = crawler.Query(false);
                    break;
                default:
                    break;
            }
        }
    }
}
