namespace SimpleInvoice.forms
{
    partial class frmInvoiceLines
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
            this.components = new System.ComponentModel.Container();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.txtName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.currencyTextBox1 = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.sfNumericTextBox1 = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.btnAddLine = new Syncfusion.WinForms.Controls.SfButton();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2007Black;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtName.BeforeTouchSize = new System.Drawing.Size(226, 23);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(156, 19);
            this.txtName.Name = "txtName";
            this.txtName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.txtName.Size = new System.Drawing.Size(268, 23);
            this.txtName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtName.TabIndex = 1;
            this.txtName.ThemeName = "Office2007";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(156, 1);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(67, 15);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "Description";
            this.autoLabel1.ThemeName = "Office2007Black";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(5, 1);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(35, 15);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Code";
            this.autoLabel2.ThemeName = "Office2007Black";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtCode.BeforeTouchSize = new System.Drawing.Size(226, 23);
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(5, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.txtCode.Size = new System.Drawing.Size(136, 23);
            this.txtCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtCode.TabIndex = 0;
            this.txtCode.ThemeName = "Office2007";
            // 
            // currencyTextBox1
            // 
            this.currencyTextBox1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.currencyTextBox1.BeforeTouchSize = new System.Drawing.Size(226, 23);
            this.currencyTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.currencyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currencyTextBox1.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.currencyTextBox1.Location = new System.Drawing.Point(489, 19);
            this.currencyTextBox1.Name = "currencyTextBox1";
            this.currencyTextBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.currencyTextBox1.Size = new System.Drawing.Size(100, 23);
            this.currencyTextBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.currencyTextBox1.TabIndex = 3;
            this.currencyTextBox1.Text = "$0.00";
            this.currencyTextBox1.ThemeName = "Office2007";
            // 
            // sfNumericTextBox1
            // 
            this.sfNumericTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sfNumericTextBox1.Location = new System.Drawing.Point(430, 18);
            this.sfNumericTextBox1.Name = "sfNumericTextBox1";
            this.sfNumericTextBox1.Size = new System.Drawing.Size(53, 23);
            this.sfNumericTextBox1.Style.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfNumericTextBox1.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfNumericTextBox1.TabIndex = 2;
            this.sfNumericTextBox1.Text = "0.000";
            this.sfNumericTextBox1.ThemeName = "Office2007Black";
            this.sfNumericTextBox1.UseWaitCursor = true;
            // 
            // btnAddLine
            // 
            this.btnAddLine.AccessibleName = "Button";
            this.btnAddLine.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddLine.Location = new System.Drawing.Point(541, 57);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(96, 28);
            this.btnAddLine.TabIndex = 6;
            this.btnAddLine.Text = "Add Line";
            this.btnAddLine.ThemeName = "Office2007Black";
            this.btnAddLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.Location = new System.Drawing.Point(5, 57);
            this.radioButtonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButtonAdv1.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007;
            this.radioButtonAdv1.TabIndex = 4;
            this.radioButtonAdv1.Text = "Free Text Item";
            this.radioButtonAdv1.ThemeName = "Office2007";
            // 
            // radioButtonAdv2
            // 
            this.radioButtonAdv2.Location = new System.Drawing.Point(156, 57);
            this.radioButtonAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonAdv2.Name = "radioButtonAdv2";
            this.radioButtonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButtonAdv2.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007;
            this.radioButtonAdv2.TabIndex = 5;
            this.radioButtonAdv2.Text = "Previous Invoice Item";
            this.radioButtonAdv2.ThemeName = "Office2007";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(643, 57);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.ThemeName = "Office2007Black";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 90);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.radioButtonAdv2);
            this.Controls.Add(this.radioButtonAdv1);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.sfNumericTextBox1);
            this.Controls.Add(this.currencyTextBox1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoiceLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Invoice Line";
            this.ThemeName = "Office2007Black";
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.SkinManager skinManager1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCode;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtName;
        private Syncfusion.WinForms.Controls.SfButton btnAddLine;
        private Syncfusion.WinForms.Input.SfNumericTextBox sfNumericTextBox1;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox currencyTextBox1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv1;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}