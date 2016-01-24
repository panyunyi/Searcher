using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Searcher
{
    public partial class Searcher : Form
    {
        public Searcher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.getDISC();
        }

        private void loadDB()
        {
            if()
        }

        private void getDISC()
        {
            DriveInfo[] dir = DriveInfo.GetDrives();
            foreach (DriveInfo d in dir)
            {
                if (d.DriveType == DriveType.Fixed)
                {
                    this.chklst.Items.Add(d.Name);
                }
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAll.Checked)
            {
                this.setItemChecked(true);
            }
            else
            {
                this.setItemChecked(false);
            }
        }

        private void setItemChecked(bool status)
        {
            for (int i = 0; i < this.chklst.Items.Count; i++)
            {
                this.chklst.SetItemChecked(i, status);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void lstResult_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush FontBrush = null;
            ListBox listBox = sender as ListBox;
            if (e.Index > -1)
            {
                
                e.DrawBackground();
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, FontBrush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private bool isExist(string filename)
        {
            return new FileInfo(filename).Exists;
        }
    }
}
