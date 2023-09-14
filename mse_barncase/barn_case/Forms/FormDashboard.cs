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

namespace barn_case
{
    public partial class FormDashboard : Form
    {
        //private IBarnService _barnService;
        
        public FormDashboard(/*IBarnService barnService*/)
        {
            InitializeComponent();
            //_barnService = barnService;

            lblDateTime.Text = DateTime.Now.ToString();
        }
     
    }
}
