using System;

namespace CsharpWeekSeven
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
            this.creataButton = new System.Windows.Forms.Button();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.perLabel = new System.Windows.Forms.Label();
            this.perRightLabel = new System.Windows.Forms.Label();
            this.thLeftLabel = new System.Windows.Forms.Label();
            this.thRightLabel = new System.Windows.Forms.Label();
            this.thRightTextBox = new System.Windows.Forms.TextBox();
            this.perRightTextBox = new System.Windows.Forms.TextBox();
            this.thLeftTextBox = new System.Windows.Forms.TextBox();
            this.perLeftTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.thRightTrackBar = new System.Windows.Forms.TrackBar();
            this.thLeftTrackBar = new System.Windows.Forms.TrackBar();
            this.perRightTrackBar = new System.Windows.Forms.TrackBar();
            this.perLeftTrackBar = new System.Windows.Forms.TrackBar();
            this.lengthTrackBar = new System.Windows.Forms.TrackBar();
            this.nTrackBar = new System.Windows.Forms.TrackBar();
            this.LineColorComboBox = new System.Windows.Forms.ComboBox();
            this.PicturePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thRightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thLeftTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perRightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perLeftTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // creataButton
            // 
            this.creataButton.Location = new System.Drawing.Point(187, 347);
            this.creataButton.Name = "creataButton";
            this.creataButton.Size = new System.Drawing.Size(75, 36);
            this.creataButton.TabIndex = 8;
            this.creataButton.Text = "Create";
            this.creataButton.UseVisualStyleBackColor = true;
            this.creataButton.Click += new System.EventHandler(this.creataButton_Click_1);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(187, 40);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 28);
            this.lengthTextBox.TabIndex = 2;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.nTextBox_TextChanged);
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(3, 10);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(98, 18);
            this.nLabel.TabIndex = 2;
            this.nLabel.Text = "递归长度：";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(3, 50);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(98, 18);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "主干长度：";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(187, 0);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 28);
            this.nTextBox.TabIndex = 1;
            this.nTextBox.TextChanged += new System.EventHandler(this.lengthTextBox_TextChanged);
            // 
            // perLabel
            // 
            this.perLabel.AutoSize = true;
            this.perLabel.Location = new System.Drawing.Point(3, 93);
            this.perLabel.Name = "perLabel";
            this.perLabel.Size = new System.Drawing.Size(134, 18);
            this.perLabel.TabIndex = 5;
            this.perLabel.Text = "左分支长度比：";
            // 
            // perRightLabel
            // 
            this.perRightLabel.AutoSize = true;
            this.perRightLabel.Location = new System.Drawing.Point(3, 135);
            this.perRightLabel.Name = "perRightLabel";
            this.perRightLabel.Size = new System.Drawing.Size(134, 18);
            this.perRightLabel.TabIndex = 6;
            this.perRightLabel.Text = "右分支长度比：";
            // 
            // thLeftLabel
            // 
            this.thLeftLabel.AutoSize = true;
            this.thLeftLabel.Location = new System.Drawing.Point(3, 173);
            this.thLeftLabel.Name = "thLeftLabel";
            this.thLeftLabel.Size = new System.Drawing.Size(188, 18);
            this.thLeftLabel.TabIndex = 7;
            this.thLeftLabel.Text = "左分支角度（0-90）：";
            // 
            // thRightLabel
            // 
            this.thRightLabel.AutoSize = true;
            this.thRightLabel.Location = new System.Drawing.Point(3, 219);
            this.thRightLabel.Name = "thRightLabel";
            this.thRightLabel.Size = new System.Drawing.Size(188, 18);
            this.thRightLabel.TabIndex = 8;
            this.thRightLabel.Text = "右分支角度（0-90）：";
            // 
            // thRightTextBox
            // 
            this.thRightTextBox.Location = new System.Drawing.Point(187, 219);
            this.thRightTextBox.Name = "thRightTextBox";
            this.thRightTextBox.Size = new System.Drawing.Size(100, 28);
            this.thRightTextBox.TabIndex = 6;
            this.thRightTextBox.TextChanged += new System.EventHandler(this.thRightTextBox_TextChanged);
            // 
            // perRightTextBox
            // 
            this.perRightTextBox.AcceptsTab = true;
            this.perRightTextBox.Location = new System.Drawing.Point(187, 132);
            this.perRightTextBox.Name = "perRightTextBox";
            this.perRightTextBox.Size = new System.Drawing.Size(100, 28);
            this.perRightTextBox.TabIndex = 4;
            this.perRightTextBox.TextChanged += new System.EventHandler(this.perRightTextBox_TextChanged);
            // 
            // thLeftTextBox
            // 
            this.thLeftTextBox.Location = new System.Drawing.Point(187, 173);
            this.thLeftTextBox.Name = "thLeftTextBox";
            this.thLeftTextBox.Size = new System.Drawing.Size(100, 28);
            this.thLeftTextBox.TabIndex = 5;
            this.thLeftTextBox.TextChanged += new System.EventHandler(this.thLeftTextBox_TextChanged);
            // 
            // perLeftTextBox
            // 
            this.perLeftTextBox.AcceptsTab = true;
            this.perLeftTextBox.Location = new System.Drawing.Point(187, 83);
            this.perLeftTextBox.Name = "perLeftTextBox";
            this.perLeftTextBox.Size = new System.Drawing.Size(100, 28);
            this.perLeftTextBox.TabIndex = 3;
            this.perLeftTextBox.TextChanged += new System.EventHandler(this.perLeftTextBox_TextChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(3, 262);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(62, 18);
            this.colorLabel.TabIndex = 14;
            this.colorLabel.Text = "颜色：";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.thRightTrackBar);
            this.controlPanel.Controls.Add(this.thLeftTrackBar);
            this.controlPanel.Controls.Add(this.perRightTrackBar);
            this.controlPanel.Controls.Add(this.perLeftTrackBar);
            this.controlPanel.Controls.Add(this.lengthTrackBar);
            this.controlPanel.Controls.Add(this.nTrackBar);
            this.controlPanel.Controls.Add(this.LineColorComboBox);
            this.controlPanel.Controls.Add(this.creataButton);
            this.controlPanel.Controls.Add(this.thRightTextBox);
            this.controlPanel.Controls.Add(this.thLeftTextBox);
            this.controlPanel.Controls.Add(this.colorLabel);
            this.controlPanel.Controls.Add(this.perRightTextBox);
            this.controlPanel.Controls.Add(this.nLabel);
            this.controlPanel.Controls.Add(this.perLeftTextBox);
            this.controlPanel.Controls.Add(this.nTextBox);
            this.controlPanel.Controls.Add(this.lengthLabel);
            this.controlPanel.Controls.Add(this.lengthTextBox);
            this.controlPanel.Controls.Add(this.thRightLabel);
            this.controlPanel.Controls.Add(this.perLabel);
            this.controlPanel.Controls.Add(this.thLeftLabel);
            this.controlPanel.Controls.Add(this.perRightLabel);
            this.controlPanel.Location = new System.Drawing.Point(12, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(520, 468);
            this.controlPanel.TabIndex = 15;
            this.controlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPanel_Paint);
            // 
            // thRightTrackBar
            // 
            this.thRightTrackBar.Location = new System.Drawing.Point(339, 219);
            this.thRightTrackBar.Maximum = 90;
            this.thRightTrackBar.Name = "thRightTrackBar";
            this.thRightTrackBar.Size = new System.Drawing.Size(178, 69);
            this.thRightTrackBar.TabIndex = 21;
            this.thRightTrackBar.Scroll += new System.EventHandler(this.thRightTrackBar_Scroll);
            // 
            // thLeftTrackBar
            // 
            this.thLeftTrackBar.Location = new System.Drawing.Point(339, 178);
            this.thLeftTrackBar.Maximum = 90;
            this.thLeftTrackBar.Name = "thLeftTrackBar";
            this.thLeftTrackBar.Size = new System.Drawing.Size(178, 69);
            this.thLeftTrackBar.TabIndex = 20;
            this.thLeftTrackBar.Scroll += new System.EventHandler(this.thLeftTrackBar_Scroll);
            // 
            // perRightTrackBar
            // 
            this.perRightTrackBar.Location = new System.Drawing.Point(339, 132);
            this.perRightTrackBar.Maximum = 100;
            this.perRightTrackBar.Name = "perRightTrackBar";
            this.perRightTrackBar.Size = new System.Drawing.Size(181, 69);
            this.perRightTrackBar.TabIndex = 19;
            this.perRightTrackBar.Scroll += new System.EventHandler(this.perRightTrackBar_Scroll);
            // 
            // perLeftTrackBar
            // 
            this.perLeftTrackBar.Location = new System.Drawing.Point(339, 84);
            this.perLeftTrackBar.Maximum = 100;
            this.perLeftTrackBar.Name = "perLeftTrackBar";
            this.perLeftTrackBar.Size = new System.Drawing.Size(178, 69);
            this.perLeftTrackBar.TabIndex = 18;
            this.perLeftTrackBar.Scroll += new System.EventHandler(this.perLeftTrackBar_Scroll);
            // 
            // lengthTrackBar
            // 
            this.lengthTrackBar.Location = new System.Drawing.Point(339, 42);
            this.lengthTrackBar.Maximum = 100;
            this.lengthTrackBar.Name = "lengthTrackBar";
            this.lengthTrackBar.Size = new System.Drawing.Size(178, 69);
            this.lengthTrackBar.TabIndex = 17;
            this.lengthTrackBar.Scroll += new System.EventHandler(this.lengthTrackBar_Scroll);
            // 
            // nTrackBar
            // 
            this.nTrackBar.Location = new System.Drawing.Point(339, 3);
            this.nTrackBar.Name = "nTrackBar";
            this.nTrackBar.Size = new System.Drawing.Size(178, 69);
            this.nTrackBar.TabIndex = 16;
            this.nTrackBar.Scroll += new System.EventHandler(this.nTrackBar_Scroll);
            // 
            // LineColorComboBox
            // 
            this.LineColorComboBox.FormattingEnabled = true;
            this.LineColorComboBox.Items.AddRange(new object[] {
            "RED",
            "BLUE",
            "BLACK",
            "GREEN",
            "YELLOW",
            "PINK"});
            this.LineColorComboBox.Location = new System.Drawing.Point(187, 262);
            this.LineColorComboBox.Name = "LineColorComboBox";
            this.LineColorComboBox.Size = new System.Drawing.Size(100, 26);
            this.LineColorComboBox.TabIndex = 15;
            this.LineColorComboBox.Text = "RED";
            this.LineColorComboBox.SelectedIndexChanged += new System.EventHandler(this.LineColorComboBox_SelectedIndexChanged);
            // 
            // PicturePanel
            // 
            this.PicturePanel.Location = new System.Drawing.Point(577, 12);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(512, 499);
            this.PicturePanel.TabIndex = 16;
            this.PicturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PicturePaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 523);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thRightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thLeftTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perRightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perLeftTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        /*private EventHandler test()
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private System.Windows.Forms.Button creataButton;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label perLabel;
        private System.Windows.Forms.Label perRightLabel;
        private System.Windows.Forms.Label thLeftLabel;
        private System.Windows.Forms.Label thRightLabel;
        private System.Windows.Forms.TextBox thRightTextBox;
        private System.Windows.Forms.TextBox perRightTextBox;
        private System.Windows.Forms.TextBox thLeftTextBox;
        private System.Windows.Forms.TextBox perLeftTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.FlowLayoutPanel PicturePanel;
        private System.Windows.Forms.ComboBox LineColorComboBox;
        private System.Windows.Forms.TrackBar thRightTrackBar;
        private System.Windows.Forms.TrackBar thLeftTrackBar;
        private System.Windows.Forms.TrackBar perRightTrackBar;
        private System.Windows.Forms.TrackBar perLeftTrackBar;
        private System.Windows.Forms.TrackBar lengthTrackBar;
        private System.Windows.Forms.TrackBar nTrackBar;
    }
}

