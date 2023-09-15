//using Bussiness.Abstract;
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
        //private IBarnService _barnService;
        DateTime date = DateTime.Now;

        public FormHomePage()
        {
            InitializeComponent();
            string dateNum = date.ToString("dd.MM.yyyy");
            string dateDay = date.ToString("dddd");
            lblDateNum.Text = dateNum.ToString();
            lblDateDay.Text = dateDay.ToString();
        }
    }
}
