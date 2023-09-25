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
        private IProductsViewService _productsViewService;
        public FormProductPage()
        {
            InitializeComponent();

            _barnService = DependencyInjection.ConfigureServices().GetRequiredService<IBarnService>();
            _productsViewService = DependencyInjection.ConfigureServices().GetRequiredService<IProductsViewService>();

            FormLoad();
        }
        private void FormLoad()
        {
            var barnAmount = _barnService.GetAmount();
            txtCurrent.Text = barnAmount.Data.FarmAmount.ToString();
            var products = _productsViewService.GetList();
            dataGridProductList.DataSource = products.Data;

        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSellProduct.Text = gridView1.GetFocusedRowCellValue("ProductTypeName").ToString();
            txtProductAomunt.Text = gridView1.GetFocusedRowCellValue("ProductTypePrice").ToString();
        }
    }
}
