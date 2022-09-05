using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobloxAdViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Process.Start(e.Url.ToString());
            e.Cancel = true;
        }

       

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

      

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage1)
            {
                Size = new Size(784, 179);

            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                this.Size = new Size(354, 333);
               


            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                this.Size = new Size(197, 684);



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            webBrowser2.Refresh();
            webBrowser3.Refresh();
        }

        private void webBrowser3_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Process.Start(e.Url.ToString());
            e.Cancel = true;
        }

        private void webBrowser2_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Process.Start(e.Url.ToString());
            e.Cancel = true;
        }
    }
}
