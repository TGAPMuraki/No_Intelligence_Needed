using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No_Intelligence_Needed
{
    public partial class FormMain : Form
    {
        private FormCarManager form_CarManager;
        private FormCalculations form_Calculations;
        private FormPaymentManager form_PaymentManager;

        public FormMain()
        {            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            form_CarManager = new FormCarManager();
            form_Calculations = new FormCalculations();            
            form_Calculations.form_CarManager = form_CarManager;
            form_CarManager.form_Calculations = form_Calculations;
            form_Calculations.refresh_CarList();
            form_PaymentManager = new FormPaymentManager();

            
        }

        private void btn_CarManager_Click(object sender, EventArgs e)
        {
            if (!form_CarManager.Visible)
                form_CarManager.Show();
            else
                form_CarManager.BringToFront();
        }

        private void btn_Calculations_Click(object sender, EventArgs e)
        {
            if (!form_Calculations.Visible)
                form_Calculations.Show();
            else
                form_Calculations.BringToFront();
        }

        private void btn_PaymentManager_Click(object sender, EventArgs e)
        {
            if (!form_PaymentManager.Visible)
                form_PaymentManager.Show();
            else
                form_PaymentManager.BringToFront();
        }
    }
}
