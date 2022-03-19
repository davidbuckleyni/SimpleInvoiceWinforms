namespace SimpleInvoice.forms
{
    partial class frmInvoice
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
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lvwInvoiceLines = new BrightIdeasSoftware.ObjectListView();
            this.btnAddinvoceLines = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.label3 = new System.Windows.Forms.Label();
            this.addressControl1 = new SimpleInvoice.AddressControl();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInvoiceLines)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(226, 23);
            this.textBoxExt1.Location = new System.Drawing.Point(87, 33);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(249, 23);
            this.textBoxExt1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BeforeTouchSize = new System.Drawing.Size(226, 23);
            this.txtDescription.Location = new System.Drawing.Point(87, 62);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(651, 46);
            this.txtDescription.TabIndex = 2;
            // 
            // lvwInvoiceLines
            // 
            this.lvwInvoiceLines.HideSelection = false;
            this.lvwInvoiceLines.Location = new System.Drawing.Point(133, 428);
            this.lvwInvoiceLines.Name = "lvwInvoiceLines";
            this.lvwInvoiceLines.Size = new System.Drawing.Size(629, 93);
            this.lvwInvoiceLines.TabIndex = 4;
            this.lvwInvoiceLines.View = System.Windows.Forms.View.Details;
            // 
            // btnAddinvoceLines
            // 
            this.btnAddinvoceLines.AccessibleName = "Button";
            this.btnAddinvoceLines.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddinvoceLines.Location = new System.Drawing.Point(462, 531);
            this.btnAddinvoceLines.Name = "btnAddinvoceLines";
            this.btnAddinvoceLines.Size = new System.Drawing.Size(96, 28);
            this.btnAddinvoceLines.TabIndex = 5;
            this.btnAddinvoceLines.Text = "Add";
            this.btnAddinvoceLines.UseVisualStyleBackColor = true;
            this.btnAddinvoceLines.Click += new System.EventHandler(this.btnAddinvoceLines_Click);
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfButton2.Location = new System.Drawing.Point(564, 531);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(96, 28);
            this.sfButton2.TabIndex = 6;
            this.sfButton2.Text = "Remove";
            this.sfButton2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(666, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Invoice Lines";
            // 
            // addressControl1
            // 
            this.addressControl1.Location = new System.Drawing.Point(4, 126);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(757, 296);
            this.addressControl1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Company";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.sfButton2);
            this.Controls.Add(this.btnAddinvoceLines);
            this.Controls.Add(this.lvwInvoiceLines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExt1);
            this.Name = "frmInvoice";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInvoiceLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDescription;
        private BrightIdeasSoftware.ObjectListView lvwInvoiceLines;
        private Syncfusion.WinForms.Controls.SfButton btnAddinvoceLines;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Label label3;
        private AddressControl addressControl1;
        private System.Windows.Forms.Label label4;
    }
}