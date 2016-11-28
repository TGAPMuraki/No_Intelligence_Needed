namespace No_Intelligence_Needed
{
    partial class FormCarManager
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Grid = new System.Windows.Forms.Panel();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.btn_Save);
            this.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Buttons.Location = new System.Drawing.Point(0, 520);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(414, 29);
            this.pnl_Buttons.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(3, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(408, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Speichern";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pnl_Grid
            // 
            this.pnl_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Grid.Location = new System.Drawing.Point(0, 0);
            this.pnl_Grid.Name = "pnl_Grid";
            this.pnl_Grid.Size = new System.Drawing.Size(414, 520);
            this.pnl_Grid.TabIndex = 1;
            // 
            // FormCarManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 549);
            this.Controls.Add(this.pnl_Grid);
            this.Controls.Add(this.pnl_Buttons);
            this.Name = "FormCarManager";
            this.ShowIcon = false;
            this.Text = "Fahrzeugverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCarManager_FormClosing);
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Panel pnl_Grid;
        private System.Windows.Forms.Button btn_Save;
    }
}

