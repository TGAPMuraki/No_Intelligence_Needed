namespace No_Intelligence_Needed
{
    partial class FormPaymentManager
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
            this.pnl_BlackList = new System.Windows.Forms.Panel();
            this.btn_DidPay2 = new System.Windows.Forms.Button();
            this.btn_HasToPay2 = new System.Windows.Forms.Button();
            this.btn_AddBlackList = new System.Windows.Forms.Button();
            this.tbox_BlackList = new System.Windows.Forms.TextBox();
            this.lbox_BlackList = new System.Windows.Forms.ListBox();
            this.pnl_PayedList = new System.Windows.Forms.Panel();
            this.btn_DidNotPay2 = new System.Windows.Forms.Button();
            this.btn_HasToPay = new System.Windows.Forms.Button();
            this.btn_AddPayedList = new System.Windows.Forms.Button();
            this.tbox_PayedList = new System.Windows.Forms.TextBox();
            this.lbox_PayedList = new System.Windows.Forms.ListBox();
            this.pnl_ToPayList = new System.Windows.Forms.Panel();
            this.btn_DidNotPay = new System.Windows.Forms.Button();
            this.btn_DidPay = new System.Windows.Forms.Button();
            this.btn_AddToPayList = new System.Windows.Forms.Button();
            this.tbox_ToPayList = new System.Windows.Forms.TextBox();
            this.lbox_ToPayList = new System.Windows.Forms.ListBox();
            this.pnl_Description = new System.Windows.Forms.Panel();
            this.lbl_BlackList = new System.Windows.Forms.Label();
            this.lbl_PayedList = new System.Windows.Forms.Label();
            this.lbl_ToPayList = new System.Windows.Forms.Label();
            this.pnl_SaveButton = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_BlackList.SuspendLayout();
            this.pnl_PayedList.SuspendLayout();
            this.pnl_ToPayList.SuspendLayout();
            this.pnl_Description.SuspendLayout();
            this.pnl_SaveButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BlackList
            // 
            this.pnl_BlackList.Controls.Add(this.btn_DidPay2);
            this.pnl_BlackList.Controls.Add(this.btn_HasToPay2);
            this.pnl_BlackList.Controls.Add(this.btn_AddBlackList);
            this.pnl_BlackList.Controls.Add(this.tbox_BlackList);
            this.pnl_BlackList.Controls.Add(this.lbox_BlackList);
            this.pnl_BlackList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_BlackList.Location = new System.Drawing.Point(489, 19);
            this.pnl_BlackList.Name = "pnl_BlackList";
            this.pnl_BlackList.Size = new System.Drawing.Size(244, 305);
            this.pnl_BlackList.TabIndex = 1;
            // 
            // btn_DidPay2
            // 
            this.btn_DidPay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DidPay2.Location = new System.Drawing.Point(125, 278);
            this.btn_DidPay2.Name = "btn_DidPay2";
            this.btn_DidPay2.Size = new System.Drawing.Size(116, 23);
            this.btn_DidPay2.TabIndex = 8;
            this.btn_DidPay2.Text = "Hat Bezahlt";
            this.btn_DidPay2.UseVisualStyleBackColor = true;
            this.btn_DidPay2.Click += new System.EventHandler(this.btn_MoveListBoxEntry_Click);
            // 
            // btn_HasToPay2
            // 
            this.btn_HasToPay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HasToPay2.Location = new System.Drawing.Point(3, 278);
            this.btn_HasToPay2.Name = "btn_HasToPay2";
            this.btn_HasToPay2.Size = new System.Drawing.Size(116, 23);
            this.btn_HasToPay2.TabIndex = 7;
            this.btn_HasToPay2.Text = "Muss noch Zahlen";
            this.btn_HasToPay2.UseVisualStyleBackColor = true;
            this.btn_HasToPay2.Click += new System.EventHandler(this.btn_MoveListBoxEntry_Click);
            // 
            // btn_AddBlackList
            // 
            this.btn_AddBlackList.Location = new System.Drawing.Point(166, 3);
            this.btn_AddBlackList.Name = "btn_AddBlackList";
            this.btn_AddBlackList.Size = new System.Drawing.Size(75, 23);
            this.btn_AddBlackList.TabIndex = 6;
            this.btn_AddBlackList.Text = "Hinzufügen";
            this.btn_AddBlackList.UseVisualStyleBackColor = true;
            this.btn_AddBlackList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // tbox_BlackList
            // 
            this.tbox_BlackList.Location = new System.Drawing.Point(3, 5);
            this.tbox_BlackList.Name = "tbox_BlackList";
            this.tbox_BlackList.Size = new System.Drawing.Size(157, 20);
            this.tbox_BlackList.TabIndex = 5;
            this.tbox_BlackList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_ToPayList_KeyDown);
            // 
            // lbox_BlackList
            // 
            this.lbox_BlackList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbox_BlackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbox_BlackList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_BlackList.FormattingEnabled = true;
            this.lbox_BlackList.ItemHeight = 20;
            this.lbox_BlackList.Location = new System.Drawing.Point(3, 29);
            this.lbox_BlackList.Name = "lbox_BlackList";
            this.lbox_BlackList.Size = new System.Drawing.Size(238, 244);
            this.lbox_BlackList.TabIndex = 1;
            // 
            // pnl_PayedList
            // 
            this.pnl_PayedList.Controls.Add(this.btn_DidNotPay2);
            this.pnl_PayedList.Controls.Add(this.btn_HasToPay);
            this.pnl_PayedList.Controls.Add(this.btn_AddPayedList);
            this.pnl_PayedList.Controls.Add(this.tbox_PayedList);
            this.pnl_PayedList.Controls.Add(this.lbox_PayedList);
            this.pnl_PayedList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_PayedList.Location = new System.Drawing.Point(245, 19);
            this.pnl_PayedList.Name = "pnl_PayedList";
            this.pnl_PayedList.Size = new System.Drawing.Size(244, 305);
            this.pnl_PayedList.TabIndex = 2;
            // 
            // btn_DidNotPay2
            // 
            this.btn_DidNotPay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DidNotPay2.Location = new System.Drawing.Point(125, 278);
            this.btn_DidNotPay2.Name = "btn_DidNotPay2";
            this.btn_DidNotPay2.Size = new System.Drawing.Size(116, 23);
            this.btn_DidNotPay2.TabIndex = 6;
            this.btn_DidNotPay2.Text = "Hat NICHT Bezahlt";
            this.btn_DidNotPay2.UseVisualStyleBackColor = true;
            this.btn_DidNotPay2.Click += new System.EventHandler(this.btn_MoveListBoxEntry_Click);
            // 
            // btn_HasToPay
            // 
            this.btn_HasToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HasToPay.Location = new System.Drawing.Point(3, 278);
            this.btn_HasToPay.Name = "btn_HasToPay";
            this.btn_HasToPay.Size = new System.Drawing.Size(116, 23);
            this.btn_HasToPay.TabIndex = 5;
            this.btn_HasToPay.Text = "Muss noch Zahlen";
            this.btn_HasToPay.UseVisualStyleBackColor = true;
            this.btn_HasToPay.Click += new System.EventHandler(this.btn_MoveListBoxEntry_Click);
            // 
            // btn_AddPayedList
            // 
            this.btn_AddPayedList.Location = new System.Drawing.Point(166, 3);
            this.btn_AddPayedList.Name = "btn_AddPayedList";
            this.btn_AddPayedList.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPayedList.TabIndex = 4;
            this.btn_AddPayedList.Text = "Hinzufügen";
            this.btn_AddPayedList.UseVisualStyleBackColor = true;
            this.btn_AddPayedList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // tbox_PayedList
            // 
            this.tbox_PayedList.Location = new System.Drawing.Point(3, 5);
            this.tbox_PayedList.Name = "tbox_PayedList";
            this.tbox_PayedList.Size = new System.Drawing.Size(157, 20);
            this.tbox_PayedList.TabIndex = 3;
            this.tbox_PayedList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_ToPayList_KeyDown);
            // 
            // lbox_PayedList
            // 
            this.lbox_PayedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbox_PayedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbox_PayedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_PayedList.FormattingEnabled = true;
            this.lbox_PayedList.ItemHeight = 20;
            this.lbox_PayedList.Location = new System.Drawing.Point(3, 29);
            this.lbox_PayedList.Name = "lbox_PayedList";
            this.lbox_PayedList.Size = new System.Drawing.Size(238, 244);
            this.lbox_PayedList.TabIndex = 0;
            // 
            // pnl_ToPayList
            // 
            this.pnl_ToPayList.Controls.Add(this.btn_DidNotPay);
            this.pnl_ToPayList.Controls.Add(this.btn_DidPay);
            this.pnl_ToPayList.Controls.Add(this.btn_AddToPayList);
            this.pnl_ToPayList.Controls.Add(this.tbox_ToPayList);
            this.pnl_ToPayList.Controls.Add(this.lbox_ToPayList);
            this.pnl_ToPayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ToPayList.Location = new System.Drawing.Point(0, 19);
            this.pnl_ToPayList.Name = "pnl_ToPayList";
            this.pnl_ToPayList.Size = new System.Drawing.Size(245, 305);
            this.pnl_ToPayList.TabIndex = 0;
            // 
            // btn_DidNotPay
            // 
            this.btn_DidNotPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DidNotPay.Location = new System.Drawing.Point(125, 278);
            this.btn_DidNotPay.Name = "btn_DidNotPay";
            this.btn_DidNotPay.Size = new System.Drawing.Size(116, 23);
            this.btn_DidNotPay.TabIndex = 4;
            this.btn_DidNotPay.Text = "Hat NICHT Bezahlt";
            this.btn_DidNotPay.UseVisualStyleBackColor = true;
            this.btn_DidNotPay.Click += new System.EventHandler(this.btn_MoveListBoxEntry_Click);
            // 
            // btn_DidPay
            // 
            this.btn_DidPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DidPay.Location = new System.Drawing.Point(3, 278);
            this.btn_DidPay.Name = "btn_DidPay";
            this.btn_DidPay.Size = new System.Drawing.Size(116, 23);
            this.btn_DidPay.TabIndex = 3;
            this.btn_DidPay.Text = "Hat Bezahlt";
            this.btn_DidPay.UseVisualStyleBackColor = true;
            this.btn_DidPay.Click += new System.EventHandler(this.btn_MoveListBoxEntry_Click);
            // 
            // btn_AddToPayList
            // 
            this.btn_AddToPayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddToPayList.Location = new System.Drawing.Point(167, 3);
            this.btn_AddToPayList.Name = "btn_AddToPayList";
            this.btn_AddToPayList.Size = new System.Drawing.Size(75, 23);
            this.btn_AddToPayList.TabIndex = 2;
            this.btn_AddToPayList.Text = "Hinzufügen";
            this.btn_AddToPayList.UseVisualStyleBackColor = true;
            this.btn_AddToPayList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // tbox_ToPayList
            // 
            this.tbox_ToPayList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_ToPayList.Location = new System.Drawing.Point(3, 5);
            this.tbox_ToPayList.Name = "tbox_ToPayList";
            this.tbox_ToPayList.Size = new System.Drawing.Size(158, 20);
            this.tbox_ToPayList.TabIndex = 1;
            this.tbox_ToPayList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_ToPayList_KeyDown);
            // 
            // lbox_ToPayList
            // 
            this.lbox_ToPayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_ToPayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbox_ToPayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_ToPayList.FormattingEnabled = true;
            this.lbox_ToPayList.ItemHeight = 20;
            this.lbox_ToPayList.Location = new System.Drawing.Point(3, 29);
            this.lbox_ToPayList.Name = "lbox_ToPayList";
            this.lbox_ToPayList.Size = new System.Drawing.Size(239, 244);
            this.lbox_ToPayList.TabIndex = 0;
            // 
            // pnl_Description
            // 
            this.pnl_Description.Controls.Add(this.lbl_BlackList);
            this.pnl_Description.Controls.Add(this.lbl_PayedList);
            this.pnl_Description.Controls.Add(this.lbl_ToPayList);
            this.pnl_Description.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Description.Location = new System.Drawing.Point(0, 0);
            this.pnl_Description.Name = "pnl_Description";
            this.pnl_Description.Size = new System.Drawing.Size(733, 19);
            this.pnl_Description.TabIndex = 3;
            // 
            // lbl_BlackList
            // 
            this.lbl_BlackList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BlackList.AutoSize = true;
            this.lbl_BlackList.Location = new System.Drawing.Point(489, 3);
            this.lbl_BlackList.Name = "lbl_BlackList";
            this.lbl_BlackList.Size = new System.Drawing.Size(50, 13);
            this.lbl_BlackList.TabIndex = 2;
            this.lbl_BlackList.Text = "BlackList";
            // 
            // lbl_PayedList
            // 
            this.lbl_PayedList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PayedList.AutoSize = true;
            this.lbl_PayedList.Location = new System.Drawing.Point(245, 3);
            this.lbl_PayedList.Name = "lbl_PayedList";
            this.lbl_PayedList.Size = new System.Drawing.Size(139, 13);
            this.lbl_PayedList.TabIndex = 1;
            this.lbl_PayedList.Text = "Abgeschlossene Zahlungen";
            // 
            // lbl_ToPayList
            // 
            this.lbl_ToPayList.AutoSize = true;
            this.lbl_ToPayList.Location = new System.Drawing.Point(3, 3);
            this.lbl_ToPayList.Name = "lbl_ToPayList";
            this.lbl_ToPayList.Size = new System.Drawing.Size(123, 13);
            this.lbl_ToPayList.TabIndex = 0;
            this.lbl_ToPayList.Text = "Ausstehende Zahlungen";
            // 
            // pnl_SaveButton
            // 
            this.pnl_SaveButton.Controls.Add(this.btn_Save);
            this.pnl_SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_SaveButton.Location = new System.Drawing.Point(0, 324);
            this.pnl_SaveButton.Name = "pnl_SaveButton";
            this.pnl_SaveButton.Size = new System.Drawing.Size(733, 39);
            this.pnl_SaveButton.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(3, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(727, 33);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Speichern";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FormPaymentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 363);
            this.Controls.Add(this.pnl_ToPayList);
            this.Controls.Add(this.pnl_PayedList);
            this.Controls.Add(this.pnl_BlackList);
            this.Controls.Add(this.pnl_Description);
            this.Controls.Add(this.pnl_SaveButton);
            this.Name = "FormPaymentManager";
            this.ShowIcon = false;
            this.Text = "Zahlungsverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPaymentManager_FormClosing);
            this.pnl_BlackList.ResumeLayout(false);
            this.pnl_BlackList.PerformLayout();
            this.pnl_PayedList.ResumeLayout(false);
            this.pnl_PayedList.PerformLayout();
            this.pnl_ToPayList.ResumeLayout(false);
            this.pnl_ToPayList.PerformLayout();
            this.pnl_Description.ResumeLayout(false);
            this.pnl_Description.PerformLayout();
            this.pnl_SaveButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_BlackList;
        private System.Windows.Forms.ListBox lbox_BlackList;
        private System.Windows.Forms.Panel pnl_PayedList;
        private System.Windows.Forms.Panel pnl_ToPayList;
        private System.Windows.Forms.TextBox tbox_ToPayList;
        private System.Windows.Forms.ListBox lbox_ToPayList;
        private System.Windows.Forms.Button btn_AddToPayList;
        private System.Windows.Forms.Button btn_DidNotPay;
        private System.Windows.Forms.Button btn_DidPay;
        private System.Windows.Forms.ListBox lbox_PayedList;
        private System.Windows.Forms.Button btn_AddPayedList;
        private System.Windows.Forms.TextBox tbox_PayedList;
        private System.Windows.Forms.Button btn_DidPay2;
        private System.Windows.Forms.Button btn_HasToPay2;
        private System.Windows.Forms.Button btn_AddBlackList;
        private System.Windows.Forms.TextBox tbox_BlackList;
        private System.Windows.Forms.Button btn_DidNotPay2;
        private System.Windows.Forms.Button btn_HasToPay;
        private System.Windows.Forms.Panel pnl_Description;
        private System.Windows.Forms.Label lbl_BlackList;
        private System.Windows.Forms.Label lbl_PayedList;
        private System.Windows.Forms.Label lbl_ToPayList;
        private System.Windows.Forms.Panel pnl_SaveButton;
        private System.Windows.Forms.Button btn_Save;
    }
}