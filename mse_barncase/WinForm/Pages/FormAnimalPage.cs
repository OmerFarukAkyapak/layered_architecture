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
    public partial class FormAnimalPage : Form
    {
        private IBarnService _barnService;
        private IAnimalService _animalService;
        private IProductService _productService;
        private IAnimalTypesService _animalTypesService;
        private IAnimalGendersService _animalGendersService;
        private IProductTypesService _productTypesService;
        private IAnimalViewService _animalsViewService;
        public FormAnimalPage()
        {
            InitializeComponent();

            _barnService = DependencyInjection.ConfigureServices().GetRequiredService<IBarnService>();
            _animalService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalService>();
            _productService = DependencyInjection.ConfigureServices().GetRequiredService<IProductService>();
            _animalTypesService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalTypesService>();
            _animalGendersService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalGendersService>();
            _productTypesService = DependencyInjection.ConfigureServices().GetRequiredService<IProductTypesService>();
            _animalsViewService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalViewService>();

            FormLoad();
        }
        private void FormLoad()
        {
            var barnAmount = _barnService.GetAmount();
            txtFarmCurrent.Text = barnAmount.Data.FarmAmount.ToString();
            var animals = _animalsViewService.GetList();
            dataGridAnimalList.DataSource = animals.Data;

            //buy animal side
            var animalTypeNames = _animalTypesService.GetAnimalTypeNames();
            cmbBoxAnimalType.DataSource = animalTypeNames.Data;

            var animalGenderNames = _animalGendersService.GetAnimalGenderNames();
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
            txtSellAnimal.Text = gridView1.GetFocusedRowCellValue("TypeName").ToString();
            txtSellAnimalAmount.Text = gridView1.GetFocusedRowCellValue("TypePrice").ToString();
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }
    }
}
