using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barn_case
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            OpenTabPage<FormDashboard>("Home Page");
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
    }
}
