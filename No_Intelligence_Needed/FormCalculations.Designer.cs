namespace No_Intelligence_Needed
{
    partial class FormCalculations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Calculation = new System.Windows.Forms.Panel();
            this.tbox_Result = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.tbox_CarValue = new System.Windows.Forms.TextBox();
            this.lbl_CarValue = new System.Windows.Forms.Label();
            this.tbox_Percent = new System.Windows.Forms.TextBox();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.tbox_Capacity = new System.Windows.Forms.TextBox();
            this.lbl_Capacity = new System.Windows.Forms.Label();
            this.lbl_Cars = new System.Windows.Forms.Label();
            this.cbox_Cars = new System.Windows.Forms.ComboBox();
            this.pnl_Calculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Calculation
            // 
            this.pnl_Calculation.Controls.Add(this.tbox_Result);
            this.pnl_Calculation.Controls.Add(this.lbl_Result);
            this.pnl_Calculation.Controls.Add(this.tbox_CarValue);
            this.pnl_Calculation.Controls.Add(this.lbl_CarValue);
            this.pnl_Calculation.Controls.Add(this.tbox_Percent);
            this.pnl_Calculation.Controls.Add(this.lbl_Percent);
            this.pnl_Calculation.Controls.Add(this.tbox_Capacity);
            this.pnl_Calculation.Controls.Add(this.lbl_Capacity);
            this.pnl_Calculation.Controls.Add(this.lbl_Cars);
            this.pnl_Calculation.Controls.Add(this.cbox_Cars);
            this.pnl_Calculation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Calculation.Location = new System.Drawing.Point(0, 0);
            this.pnl_Calculation.Name = "pnl_Calculation";
            this.pnl_Calculation.Size = new System.Drawing.Size(240, 137);
            this.pnl_Calculation.TabIndex = 9;
            // 
            // tbox_Result
            // 
            this.tbox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Result.Location = new System.Drawing.Point(6, 108);
            this.tbox_Result.Name = "tbox_Result";
            this.tbox_Result.ReadOnly = true;
            this.tbox_Result.Size = new System.Drawing.Size(225, 20);
            this.tbox_Result.TabIndex = 17;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(3, 92);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(48, 13);
            this.lbl_Result.TabIndex = 18;
            this.lbl_Result.Text = "Ergebnis";
            // 
            // tbox_CarValue
            // 
            this.tbox_CarValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_CarValue.Location = new System.Drawing.Point(6, 67);
            this.tbox_CarValue.Name = "tbox_CarValue";
            this.tbox_CarValue.Size = new System.Drawing.Size(105, 20);
            this.tbox_CarValue.TabIndex = 10;
            this.tbox_CarValue.TextChanged += new System.EventHandler(this.tbox_CarValue_TextChanged);
            // 
            // lbl_CarValue
            // 
            this.lbl_CarValue.AutoSize = true;
            this.lbl_CarValue.Location = new System.Drawing.Point(3, 51);
            this.lbl_CarValue.Name = "lbl_CarValue";
            this.lbl_CarValue.Size = new System.Drawing.Size(54, 13);
            this.lbl_CarValue.TabIndex = 16;
            this.lbl_CarValue.Text = "Marktwert";
            // 
            // tbox_Percent
            // 
            this.tbox_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Percent.Location = new System.Drawing.Point(177, 67);
            this.tbox_Percent.Name = "tbox_Percent";
            this.tbox_Percent.Size = new System.Drawing.Size(54, 20);
            this.tbox_Percent.TabIndex = 14;
            this.tbox_Percent.Text = "20";
            this.tbox_Percent.TextChanged += new System.EventHandler(this.tbox_CarValue_TextChanged);
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.Location = new System.Drawing.Point(177, 51);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(15, 13);
            this.lbl_Percent.TabIndex = 15;
            this.lbl_Percent.Text = "%";
            // 
            // tbox_Capacity
            // 
            this.tbox_Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Capacity.Location = new System.Drawing.Point(117, 67);
            this.tbox_Capacity.Name = "tbox_Capacity";
            this.tbox_Capacity.ReadOnly = true;
            this.tbox_Capacity.Size = new System.Drawing.Size(54, 20);
            this.tbox_Capacity.TabIndex = 12;
            // 
            // lbl_Capacity
            // 
            this.lbl_Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Capacity.AutoSize = true;
            this.lbl_Capacity.Location = new System.Drawing.Point(114, 51);
            this.lbl_Capacity.Name = "lbl_Capacity";
            this.lbl_Capacity.Size = new System.Drawing.Size(57, 13);
            this.lbl_Capacity.TabIndex = 13;
            this.lbl_Capacity.Text = "Lagerraum";
            // 
            // lbl_Cars
            // 
            this.lbl_Cars.AutoSize = true;
            this.lbl_Cars.Location = new System.Drawing.Point(3, 9);
            this.lbl_Cars.Name = "lbl_Cars";
            this.lbl_Cars.Size = new System.Drawing.Size(57, 13);
            this.lbl_Cars.TabIndex = 11;
            this.lbl_Cars.Text = "Fahrzeuge";
            // 
            // cbox_Cars
            // 
            this.cbox_Cars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_Cars.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_Cars.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_Cars.FormattingEnabled = true;
            this.cbox_Cars.Location = new System.Drawing.Point(6, 25);
            this.cbox_Cars.Name = "cbox_Cars";
            this.cbox_Cars.Size = new System.Drawing.Size(225, 21);
            this.cbox_Cars.TabIndex = 9;
            this.cbox_Cars.Text = "Fahrzeuge";
            this.cbox_Cars.SelectedIndexChanged += new System.EventHandler(this.cbox_Cars_SelectedIndexChanged);
            // 
            // FormCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 139);
            this.Controls.Add(this.pnl_Calculation);
            this.Name = "FormCalculations";
            this.ShowIcon = false;
            this.Text = "Kalkulationen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculations_FormClosing);
            this.pnl_Calculation.ResumeLayout(false);
            this.pnl_Calculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Calculation;
        private System.Windows.Forms.TextBox tbox_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox tbox_CarValue;
        private System.Windows.Forms.Label lbl_CarValue;
        private System.Windows.Forms.TextBox tbox_Percent;
        private System.Windows.Forms.Label lbl_Percent;
        private System.Windows.Forms.TextBox tbox_Capacity;
        private System.Windows.Forms.Label lbl_Capacity;
        private System.Windows.Forms.Label lbl_Cars;
        private System.Windows.Forms.ComboBox cbox_Cars;
    }
}