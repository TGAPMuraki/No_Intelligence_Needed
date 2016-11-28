namespace No_Intelligence_Needed
{
    partial class FormMain
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
            this.picbox_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Calculations = new System.Windows.Forms.Button();
            this.btn_CarManager = new System.Windows.Forms.Button();
            this.btn_PaymentManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_Logo
            // 
            this.picbox_Logo.Image = global::No_Intelligence_Needed.Properties.Resources.NIN_Logo;
            this.picbox_Logo.InitialImage = null;
            this.picbox_Logo.Location = new System.Drawing.Point(0, 0);
            this.picbox_Logo.Name = "picbox_Logo";
            this.picbox_Logo.Size = new System.Drawing.Size(404, 155);
            this.picbox_Logo.TabIndex = 0;
            this.picbox_Logo.TabStop = false;
            // 
            // btn_Calculations
            // 
            this.btn_Calculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculations.Location = new System.Drawing.Point(139, 155);
            this.btn_Calculations.Name = "btn_Calculations";
            this.btn_Calculations.Size = new System.Drawing.Size(125, 23);
            this.btn_Calculations.TabIndex = 1;
            this.btn_Calculations.Text = "Kalkulationen";
            this.btn_Calculations.UseVisualStyleBackColor = true;
            this.btn_Calculations.Click += new System.EventHandler(this.btn_Calculations_Click);
            // 
            // btn_CarManager
            // 
            this.btn_CarManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CarManager.Location = new System.Drawing.Point(0, 155);
            this.btn_CarManager.Name = "btn_CarManager";
            this.btn_CarManager.Size = new System.Drawing.Size(133, 23);
            this.btn_CarManager.TabIndex = 3;
            this.btn_CarManager.Text = "Fahrzeugverwaltung";
            this.btn_CarManager.UseVisualStyleBackColor = true;
            this.btn_CarManager.Click += new System.EventHandler(this.btn_CarManager_Click);
            // 
            // btn_PaymentManager
            // 
            this.btn_PaymentManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PaymentManager.Location = new System.Drawing.Point(270, 155);
            this.btn_PaymentManager.Name = "btn_PaymentManager";
            this.btn_PaymentManager.Size = new System.Drawing.Size(134, 23);
            this.btn_PaymentManager.TabIndex = 2;
            this.btn_PaymentManager.Text = "Zahlungsverwaltung";
            this.btn_PaymentManager.UseVisualStyleBackColor = true;
            this.btn_PaymentManager.Click += new System.EventHandler(this.btn_PaymentManager_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 178);
            this.Controls.Add(this.btn_PaymentManager);
            this.Controls.Add(this.btn_CarManager);
            this.Controls.Add(this.btn_Calculations);
            this.Controls.Add(this.picbox_Logo);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "No Intelligence Needed";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_Logo;
        private System.Windows.Forms.Button btn_Calculations;
        private System.Windows.Forms.Button btn_CarManager;
        private System.Windows.Forms.Button btn_PaymentManager;
    }
}