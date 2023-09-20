using Bussiness.Abstract;
using Bussiness.Concrete;
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
        private IServiceProvider _serviceProvider;

        DateTime date = DateTime.Now;

        public FormHomePage()
        {
            InitializeComponent();
            //DI.RegisterServices();
            _serviceProvider = DI.ServiceProvider;

        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            string dateNum = date.ToString("dd.MM.yyyy");
            string dateDay = date.ToString("dddd");
            lblDateNum.Text = dateNum.ToString();
            lblDateDay.Text = dateDay.ToString();


            if (_serviceProvider != null)
            {
                _barnService = _serviceProvider.GetRequiredService<IBarnService>();

                var barnAmount = _barnService.GetAmount();

                txtBarnAmount.Text = barnAmount.Data.FarmAmount.ToString();
            }
            else
            {
                txtBarnAmount.Text = "100";
            }
        }
    }
}
