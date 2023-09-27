using Bussiness.Abstract;
using Bussiness.DependencyResolvers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace WinForm.Pages
{
    public partial class FormAnimalPage : Form
    {
        private IBarnService _barnService;
        private IAnimalService _animalService;
        private IAnimalTypesService _animalTypesService;
        private IAnimalGendersService _animalGendersService;
        private IAnimalViewService _animalsViewService;
        public FormAnimalPage()
        {
            InitializeComponent();

            _barnService = DependencyInjection.ConfigureServices().GetRequiredService<IBarnService>();
            _animalService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalService>();
            _animalTypesService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalTypesService>();
            _animalGendersService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalGendersService>();
            _animalsViewService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalViewService>();

            FormLoad();
        }
        private void FormLoad()
        {
            var barnAmount = _barnService.GetAmount();
            txtFarmCurrent.Text = barnAmount.Data.FarmAmount.ToString();
            var animals = _animalsViewService.GetListNotSold();
            dataGridAnimalList.DataSource = animals.Data;

            //buy animal side
            var animalTypeNames = _animalTypesService.GetAnimalTypeNames();
            cmbBoxAnimalType.DataSource = animalTypeNames.Data;

            var animalGenderNames = _animalService.GetListAnimalGendersName();
            cmbBoxAnimalGender.DataSource = animalGenderNames.Data;

        }

        private void cmbBoxAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // buy animal process
            string selectedBuyAnimal = cmbBoxAnimalType.SelectedValue.ToString();
            var animalPriceToBuy = _animalTypesService.GetByTypeAmount(selectedBuyAnimal);
            txtBuyAnimalAmount.Text = animalPriceToBuy.Data.ToString();
        }

        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sell animal
            txtSelectedID.Text = gridView1.GetFocusedRowCellValue("AnimalID").ToString();
            txtSellAnimal.Text = gridView1.GetFocusedRowCellValue("TypeName").ToString();
            txtSellAnimalAmount.Text = gridView1.GetFocusedRowCellValue("TypePrice").ToString();
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }

        private void btnBuyAnimal_Click(object sender, EventArgs e)
        {
            int type = cmbBoxAnimalType.SelectedIndex + 1;
            int gender = cmbBoxAnimalGender.SelectedIndex + 1;
            int age = Convert.ToInt32(numAnimalAge.Value);

            decimal buyPrice = Convert.ToDecimal(txtBuyAnimalAmount.Text);

            DialogResult result = MessageBox.Show("Are you sure you want to do this?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _animalService.Add(type, gender, age);
                _barnService.DecreaseAmount(buyPrice);
                FormLoad();
            }
        }

        private void btnSellAnimal_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(txtSelectedID.Text);

            decimal sellPrice = Convert.ToDecimal(txtSellAnimalAmount.Text);

            DialogResult result = MessageBox.Show("Are you sure you want to do this?", "Yes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _animalService.Update(selectedID, true);
                _barnService.IncreaceAmount(sellPrice);
                FormLoad();
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel(gridView1, "");
        }
        //Excel
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
    }
}
