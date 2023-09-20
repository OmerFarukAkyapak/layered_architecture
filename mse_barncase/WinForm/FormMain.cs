using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Pages;

namespace WinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // Opens a page or selects it if already opened.
        private void OpenTabPage<T>(string tabPageName) where T : Form, new()
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Name == tabPageName)
                {
                    tabControl1.SelectedTab = tabPage;
                    return;
                }
            }

            T frm = new T();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            TabPage newTabPage = new TabPage(tabPageName);
            newTabPage.Name = tabPageName;
            newTabPage.Controls.Add(frm);

            tabControl1.TabPages.Add(newTabPage);
            tabControl1.SelectedTab = newTabPage;

            frm.Show();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            OpenTabPage <FormHomePage> ("Home Page");
        }

        private void btnAnimalPage_Click(object sender, EventArgs e)
        {
            OpenTabPage<FormAnimalPage>("Animal Page");
        }

        private void btnProductPage_Click(object sender, EventArgs e)
        {
            OpenTabPage<FormProductPage>("Product Page");
        }

        private void btnBarnDetails_Click(object sender, EventArgs e)
        {
            OpenTabPage<FormBarnDetails>("Barn Details Page");
        }
    }
}
