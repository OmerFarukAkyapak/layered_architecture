using Bussiness.Abstract;
using Bussiness.DependencyResolvers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace WinForm.Pages
{
    public partial class FormHomePage : Form
    {
        private IBarnService _barnService;
        private IAnimalService _animalService;
        private IProductService _productService;
        private IAnimalTypesService _animalTypesService;
        private IProductTypesService _productTypesService;

        DateTime date = DateTime.Now;

        public FormHomePage()
        {
            InitializeComponent();

            _barnService = DependencyInjection.ConfigureServices().GetRequiredService<IBarnService>();
            _animalService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalService>();
            _productService = DependencyInjection.ConfigureServices().GetRequiredService<IProductService>();
            _animalTypesService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalTypesService>();
            _productTypesService = DependencyInjection.ConfigureServices().GetRequiredService<IProductTypesService>();

            FormLoad();

        }
        private void FormLoad()
        {
            string dateNum = date.ToString("dd.MM.yyyy");
            string dateDay = date.ToString("dddd");
            lblDateNum.Text = dateNum.ToString();
            lblDateDay.Text = dateDay.ToString();

            var barnAmount = _barnService.GetAmount();
            txtBarnAmount.Text = barnAmount.Data.FarmAmount.ToString();

            var animals = _animalService.GetList();
            txtAnimalCount.Text = animals.Data.Count.ToString();

            var products = _productService.GetList();
            txtProductCount.Text = products.Data.Count.ToString();

            decimal animalWorth = 0;

            foreach (var animal in animals.Data)
            {
                var type = _animalTypesService.GetById(animal.AnimalTypeID);
                animalWorth = animalWorth + type.Data.TypePrice;

            }
            txtAnimalWorth.Text = animalWorth.ToString();

            decimal productWorth = 0;

            foreach (var product in products.Data)
            {
                var type = _productTypesService.GetById(product.ProductTypeID);
                productWorth = productWorth + type.Data.ProductTypePrice;

            }
            txtProductWorth.Text = productWorth.ToString();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            FormLoad();
        }
    }
}
