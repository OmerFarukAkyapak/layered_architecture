using Bussiness.Abstract;
using Bussiness.DependencyResolvers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace WinForm.Pages
{
    public partial class FormProductPage : Form
    {
        private IBarnService _barnService;
        private IProductService _productService;
        private IProductsViewService _productsViewService;
        public FormProductPage()
        {
            InitializeComponent();

            _barnService = DependencyInjection.ConfigureServices().GetRequiredService<IBarnService>();
            _productService = DependencyInjection.ConfigureServices().GetRequiredService<IProductService>();
            _productsViewService = DependencyInjection.ConfigureServices().GetRequiredService<IProductsViewService>();

            FormLoad();
        }
        private void FormLoad()
        {
            var barnAmount = _barnService.GetAmount();
            txtCurrent.Text = barnAmount.Data.FarmAmount.ToString();
            var products = _productsViewService.GetListNotSold();
            dataGridProductList.DataSource = products.Data;

        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSelectedID.Text = gridView1.GetFocusedRowCellValue("ProductID").ToString();
            txtSellProduct.Text = gridView1.GetFocusedRowCellValue("ProductTypeName").ToString();
            txtProductAomunt.Text = gridView1.GetFocusedRowCellValue("ProductTypePrice").ToString();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(txtSelectedID.Text);

            decimal sellPrice = Convert.ToDecimal(txtProductAomunt.Text);

            DialogResult result = MessageBox.Show("Are you sure you want to do this?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _productService.Update(selectedID, true);
                _barnService.IncreaceAmount(sellPrice);
                FormLoad();
            }
        }
        public void ExportToExcel(DevExpress.XtraGrid.Views.Grid.GridView GridView, string file)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "Excel |*.xlsx",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    FileName = file
                };
                dialog.ShowDialog();
                GridView.ExportToXlsx(dialog.FileName);
                MessageBox.Show(" Başarılı ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel(gridView1, "");
        }
    }
}
