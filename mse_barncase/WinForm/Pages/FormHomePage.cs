using Bussiness.Abstract;
using Bussiness.Concrete;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Concrete;
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
        DateTime date = DateTime.Now;

        public FormHomePage()
        {
            InitializeComponent();
            //_barnService = barnService;

            string dateNum = date.ToString("dd.MM.yyyy");
            string dateDay = date.ToString("dddd");
            lblDateNum.Text = dateNum.ToString();
            lblDateDay.Text = dateDay.ToString();


            //IDataResult<Barn> barnAmount = _barnService.GetAmount();
            //if (barnAmount.Success)
            //{
            //    Barn barn = barnAmount.Data;
            //    //txtBarnAmount.Text = barn.FarmAmount.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Barn miktarı alınamadı.");
            //}
        }
    }
}
