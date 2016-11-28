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
    public partial class FormPaymentManager : Form
    {
        String FileName_HasToPay;
        String FileName_HasPayed;
        String FileName_BlackList;

        //**************************************************
        // Constructor
        //**************************************************
        public FormPaymentManager()
        {
            InitializeComponent();

            FileName_HasToPay = System.IO.Directory.GetCurrentDirectory() + "\\NIN_Files\\HasToPay.txt";
            FileName_HasPayed = System.IO.Directory.GetCurrentDirectory() + "\\NIN_Files\\HasPayed.txt";
            FileName_BlackList = System.IO.Directory.GetCurrentDirectory() + "\\NIN_Files\\BlackList.txt";
            
            loadListBoxFromFile(lbox_ToPayList, FileName_HasToPay);
            loadListBoxFromFile(lbox_PayedList, FileName_HasPayed);
            loadListBoxFromFile(lbox_BlackList, FileName_BlackList);
        }

        //**************************************************
        // Starts the Calculation for the Selected Car
        //**************************************************
        public void moveListBoxEntry(ListBox sourceListBox, ListBox targetListBox)
        {
            targetListBox.Items.Add(sourceListBox.Items[sourceListBox.SelectedIndex].ToString());
            sourceListBox.Items.RemoveAt(sourceListBox.SelectedIndex);
        }

        //**************************************************
        // Adds the given Textbox correlating to it's panels Listbox
        //**************************************************
        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            TextBox textbox;
            ListBox listbox;
            if(sender == btn_AddToPayList)
            {
                textbox = tbox_ToPayList;
                listbox = lbox_ToPayList;
            }
            else if(sender == btn_AddPayedList)
            {
                textbox = tbox_PayedList;
                listbox = lbox_PayedList;
            }
            else 
            {
                textbox = tbox_BlackList;
                listbox = lbox_BlackList;
            }

            listbox.Items.Add(textbox.Text);
            textbox.Text = "";
        }

        //**************************************************
        // Handles the Funktionality for moving the 
        // ListBox-Items depending on the button clicked 
        //**************************************************
        private void btn_MoveListBoxEntry_Click(object sender, EventArgs e)
        {
            if(sender == btn_DidPay)
                moveListBoxEntry(lbox_ToPayList, lbox_PayedList);
            else if (sender == btn_DidNotPay)
                moveListBoxEntry(lbox_ToPayList, lbox_BlackList);
            else if (sender == btn_HasToPay)
                moveListBoxEntry(lbox_PayedList, lbox_ToPayList);
            else if (sender == btn_DidNotPay2)
                moveListBoxEntry(lbox_PayedList, lbox_BlackList);
            else if (sender == btn_HasToPay2)
                moveListBoxEntry(lbox_BlackList, lbox_ToPayList);
            else if (sender == btn_DidPay2)
                moveListBoxEntry(lbox_BlackList, lbox_PayedList);
        }

        //**************************************************
        // Saves a ListBox to the given File
        //**************************************************
        private void saveListBoxToFile(ListBox listBox, String fileName)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@fileName))
            {
                for(int i = 0; i < listBox.Items.Count; i++)
                {
                    file.WriteLine(listBox.Items[i].ToString());
                }
            }
        }

        //**************************************************
        // Loads a given File in to a ListBox
        //**************************************************
        private void loadListBoxFromFile(ListBox listBox, String fileName)
        {
            if (System.IO.File.Exists(fileName))
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@fileName))
                {
                    while (!file.EndOfStream)
                        listBox.Items.Add(file.ReadLine());
                }
            }
        }

        //**************************************************
        // Saves the 3 Lists in 3 seperated Files
        //**************************************************
        private void btn_Save_Click(object sender, EventArgs e)
        {
            saveListBoxToFile(lbox_ToPayList, FileName_HasToPay);
            saveListBoxToFile(lbox_PayedList, FileName_HasPayed);
            saveListBoxToFile(lbox_BlackList, FileName_BlackList);
        }

        //**************************************************
        // 
        //**************************************************
        private void tbox_ToPayList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (sender == tbox_ToPayList)
                    btn_AddToList_Click(btn_AddToPayList, null);
                else if (sender == tbox_PayedList)
                    btn_AddToList_Click(btn_AddPayedList, null);
                else if (sender == tbox_BlackList)
                    btn_AddToList_Click(btn_AddBlackList, null);
            }
        }

        //**************************************************
        // doesn't destroy the Form if it is closed
        //**************************************************
        private void FormPaymentManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
