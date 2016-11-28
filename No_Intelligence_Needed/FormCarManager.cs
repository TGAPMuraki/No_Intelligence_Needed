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

    public partial class FormCarManager : Form
    {
        public MbDataManagement.MbXmlDataGridView dgv_CarInformations;
        public String SaveFile;
        public FormCalculations form_Calculations;

        public static String col_CarName = "CAR_NAME";
        public static String col_CarCapacity = "CAR_CAPACITY";
        String[] collumns = { col_CarName, col_CarCapacity };

        public static String desc_CarName = "Fahrzeug Name";
        public static String desc_CarCapacity = "Kapazität";
        String[] description = { desc_CarName, desc_CarCapacity };

        //**************************************************
        // Constructor 
        //**************************************************
        public FormCarManager()
        {
            InitializeComponent();
            dgv_CarInformations = new MbDataManagement.MbXmlDataGridView();
            dgv_CarInformations.Parent = pnl_Grid;
            dgv_CarInformations.Dock = DockStyle.Fill;

            SaveFile = System.IO.Directory.GetCurrentDirectory() + "\\NIN_Files\\VehicleList.xml";
            for (int i = 0; i < collumns.Count(); i++)
            {
                dgv_CarInformations.Columns.Add(collumns[i], description[i]);
                dgv_CarInformations.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgv_CarInformations.LoadFromXml(SaveFile);
        }

        //**************************************************
        // Saves the Car List
        //**************************************************
        private void btn_Save_Click(object sender, EventArgs e)
        {
            dgv_CarInformations.SaveToXml(SaveFile);
            if (form_Calculations != null)
            {
                form_Calculations.refresh_CarList();
                form_Calculations.calculateOnForm();
            }
        }

        //**************************************************
        // doesn't destroy the Form if it is closed
        //**************************************************
        private void FormCarManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
