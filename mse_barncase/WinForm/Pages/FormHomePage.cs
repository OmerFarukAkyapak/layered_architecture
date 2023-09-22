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
    public partial class FormHomePage : Form
    {
        private IBarnService _barnService;
        private IAnimalService _animalService;
        private IProductService _productService;

        DateTime date = DateTime.Now;

        public FormHomePage()
        {
            InitializeComponent();

            _barnService = DependencyInjection.ConfigureServices().GetRequiredService<IBarnService>();
            _animalService = DependencyInjection.ConfigureServices().GetRequiredService<IAnimalService>();
            _productService = DependencyInjection.ConfigureServices().GetRequiredService<IProductService>();

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

            var productCount = _productService.GetList();
            txtProductCount.Text = productCount.Data.Count.ToString();
          
            

        }
    }
}
