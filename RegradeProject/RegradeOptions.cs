using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RegradeProject
{
    public partial class RegradeOptions : Form
    {
        public static String itemType;
        public static String modeType;
        public static double weaponS;
        public static double armorS;
        public static double accessoryS;
        public static double weaponSR;
        public static double armorSR;
        public static double accessorySR;
        public static double greenC;
        public static double blueC;
        public static double yellowC;
        public static double yellowCS;
        public static double redC;
        public static double redCS;
        public static double whiteC;

        public RegradeOptions()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            weaponS = Convert.ToDouble(tbWSPrice.Text);
            itemType = cbItemtype.GetItemText(this.cbItemtype.SelectedItem);
            modeType = cbMode.GetItemText(this.cbMode.SelectedItem);
            //itemType = cbItemtype.SelectedText.ToString();
            Debug.WriteLine(itemType);
            Debug.WriteLine(weaponS);
        }

        private void bSave_MouseDown(object sender, MouseEventArgs e)
        {
            bSave.Image = Properties.Resources.button_click;
        }

        private void bSave_MouseUp(object sender, MouseEventArgs e)
        {
            bSave.Image = Properties.Resources.button;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void RegradeOptions_Load(object sender, EventArgs e)
        {
            int length = 9;
            //RegradeProject.MainForm.
            tbWSPrice.Text = Convert.ToString(weaponS);
            tbASPrice.Text = Convert.ToString(armorS);
            tbAcSPrice.Text = Convert.ToString(accessoryS);
            tbRWSPrice.Text = Convert.ToString(weaponSR);
            tbRASPrice.Text = Convert.ToString(armorSR);
            tbRAcSPrice.Text = Convert.ToString(accessorySR);
            tbGCPrice.Text = Convert.ToString(greenC);
            tbBCPrice.Text = Convert.ToString(blueC);
            tbYCPrice.Text = Convert.ToString(yellowC);
            tbSYCPrice.Text = Convert.ToString(yellowCS);
            tbRCPrice.Text = Convert.ToString(redC);
            tbSRCPrice.Text = Convert.ToString(redCS);

            tbWSPrice.MaxLength = length;
            tbASPrice.MaxLength = length;
            tbAcSPrice.MaxLength = length;
            tbRWSPrice.MaxLength = length;
            tbRASPrice.MaxLength = length;
            tbRAcSPrice.MaxLength = length;
            tbGCPrice.MaxLength = length;
            tbBCPrice.MaxLength = length;
            tbYCPrice.MaxLength = length;
            tbSYCPrice.MaxLength = length;
            tbRCPrice.MaxLength = length;
            tbSRCPrice.MaxLength = length;
            //tbWSPrice.Text = Convert.ToString(whiteC);
        }
    }
}
