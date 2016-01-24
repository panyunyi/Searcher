namespace Searcher
{
    partial class Searcher
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklst
            // 
            this.chklst.FormattingEnabled = true;
            this.chklst.Location = new System.Drawing.Point(0, 0);
            this.chklst.Name = "chklst";
            this.chklst.Size = new System.Drawing.Size(253, 274);
            this.chklst.TabIndex = 0;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(0, 293);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(77, 29);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "ALL";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 35);
            this.textBox1.TabIndex = 2;
            // 
            // lstResult
            // 
            this.lstResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstResult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 24;
            this.lstResult.Location = new System.Drawing.Point(647, 0);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(544, 963);
            this.lstResult.TabIndex = 3;
            this.lstResult.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstResult_DrawItem);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 24;
            this.lstNames.Location = new System.Drawing.Point(259, 0);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(382, 700);
            this.lstNames.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 393);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 40);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 963);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chklst);
            this.Name = "Searcher";
            this.Text = "Searcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklst;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnSearch;
    }
}

