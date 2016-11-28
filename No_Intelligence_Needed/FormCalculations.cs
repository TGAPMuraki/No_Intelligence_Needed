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
    public partial class FormCalculations : Form
    {
        public FormCarManager form_CarManager;

        //**************************************************
        // Refreshes the Car-List
        //**************************************************
        public void refresh_CarList()
        {
            int lastSelectedIndex = cbox_Cars.SelectedIndex;

            cbox_Cars.Items.Clear();
            for (int i = 0; i < form_CarManager.dgv_CarInformations.RowCount - 1; i++)
            {
                cbox_Cars.Items.Add(form_CarManager.dgv_CarInformations.Rows[i].Cells[FormCarManager.col_CarName].Value.ToString());
            }

            if (lastSelectedIndex >= 0 && lastSelectedIndex < cbox_Cars.Items.Count)
                cbox_Cars.SelectedIndex = lastSelectedIndex;
        }

        //**************************************************
        // Constructor
        //**************************************************
        public FormCalculations()
        {
            InitializeComponent();      
        }

        //**************************************************
        // Calculation for the Selected Car
        //**************************************************
        private double calculation(double carCapacity, double itemCapacity, double carValue, double percentage)
        {
            return carCapacity / itemCapacity * carValue / 100 * percentage;
        }

        //**************************************************
        // Calculation From and on the Form
        //**************************************************
        public void calculateOnForm()
        {
            tbox_Capacity.Text = form_CarManager.dgv_CarInformations.Rows[cbox_Cars.SelectedIndex].Cells[FormCarManager.col_CarCapacity].Value.ToString(); 
            double value;
            if (tbox_CarValue.Text != "")
                value = Convert.ToDouble(tbox_CarValue.Text);
            else
                value = 0;

            double carCapacity = Convert.ToDouble(tbox_Capacity.Text);
            double carValue;

            if (tbox_CarValue.Text != "")
                carValue = Convert.ToDouble(tbox_CarValue.Text);
            else
                carValue = 0;

            double percent;
            if (tbox_Percent.Text != "")
                percent = Convert.ToDouble(tbox_Percent.Text);
            else
                percent = 0;

            double result = calculation(carCapacity, 6, carValue, percent);
            result = Math.Round(result);
            tbox_Result.Text = result.ToString();
        }

        //**************************************************
        // Starts the Calculation for the Selected Car
        //**************************************************
        private void cbox_Cars_SelectedIndexChanged(object sender, EventArgs e)
        {     
            calculateOnForm();
        }

        //**************************************************
        // Validates if the Value can be converted to a Number
        // And Executes the Calculation if so
        //**************************************************
        private void tbox_CarValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbox_CarValue.Text != "")
                    Convert.ToDouble(tbox_CarValue.Text);
                calculateOnForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //**************************************************
        // doesn't destroy the Form if it is closed
        //**************************************************
        private void FormCalculations_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
