using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInvoice.forms
{
    public partial class frmRotate : Form
    {
        public frmRotate()
        {
            InitializeComponent();
            BindItems();
        }

        public void BindItems()
        {
            Hashtable htImageTypes = new Hashtable();
            htImageTypes.Add("90", "RotateAngle90");
            htImageTypes.Add("180", "RotateAngle180");
            htImageTypes.Add("270", "RotateAngle270");
   
            foreach (DictionaryEntry ImageType in htImageTypes)
            {
                comboBox1.Items.Add(ImageType);
            }
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public string? RoatateDirection { get; set; }
        private void btnOk_Click(object sender, EventArgs e)
        {

            RoatateDirection = comboBox1.Text;                
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
