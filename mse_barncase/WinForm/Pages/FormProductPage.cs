using Bussiness.Abstract;
using Bussiness.DependencyResolvers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Pages
{
    public partial class FormProductPage : Form
    {
        private IBarnService _barnService;
        public FormProductPage()
        {
            InitializeComponent();

            _barnService = DependencyInjection.ConfigureServices().GetRequiredService<IBarnService>();

            FormLoad();
        }
        private void FormLoad()
        {
            var barnAmount = _barnService.GetAmount();
            txtCurrent.Text = barnAmount.Data.FarmAmount.ToString();
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }
    }
}
