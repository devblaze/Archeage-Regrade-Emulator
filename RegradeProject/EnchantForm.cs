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
    public partial class EnchantForm : Form
    {
        public EnchantForm(int stat, int grade,String type,int old)
        {
            InitializeComponent();
            if (stat == 0)
            {
                lbStatus.Text = "Failure";
                lbStatus.ForeColor = Color.Red;
            }else if (stat == 1)
            {
                lbStatus.Text = "Success!";
            }else if (stat == 2)
            {
                lbStatus.Text = "Great Success!";
            }else if (stat == 3)
            {
                lbStatus.Text = "Major Failure";
                lbStatus.ForeColor = Color.Red;
            }

            switch (grade)
            {
                case 1:
                    lbGradec.Text = "[Basic] " + type;
                    lbGradec.ForeColor = Color.Gray;
                    break;
                case 2:
                    lbGradec.Text = "[Grand] " + type;
                    lbGrade1.Text = "";
                    lbGradec.ForeColor = Color.Green;
                    break;
                case 3:
                    Debug.WriteLine(old + " grade " + grade);
                    if (old < grade-1)
                    {
                        Debug.WriteLine(old + " grade " + grade);
                        lbGrade1.Text = "[Grand]";
                        lbGrade1.ForeColor = Color.Green;
                        lbGrade2.Text = "-> [Rare]";
                        lbGrade2.ForeColor = Color.Blue;
                    }else if (old < grade-2)
                    {
                        Debug.WriteLine(old + " grade " + grade);
                        lbGrade1.Text = "[Grand]";
                        lbGrade1.ForeColor = Color.Green;
                        lbGrade2.Text = "->> [Arcane]";
                        lbGrade2.ForeColor = Color.Purple;
                    }
                    Debug.WriteLine(old + " grade " + grade);
                    lbGradec.Text = "[Rare] " + type;
                    lbGradec.ForeColor = Color.Blue;
                    break;
                case 4:
                    Debug.WriteLine(old + " grade " + grade);
                    if (old < grade - 1)
                    {
                        Debug.WriteLine(old + " grade " + grade);
                        lbGrade1.Text = "[Grand]";
                        lbGrade1.ForeColor = Color.Green;
                        lbGrade2.Text = "-> [Rare]";
                        lbGrade2.ForeColor = Color.Blue;
                    }
                    else if (old < grade - 2)
                    {
                        Debug.WriteLine(old + " grade " + grade);
                        lbGrade1.Text = "[Grand]";
                        lbGrade1.ForeColor = Color.Green;
                        lbGrade2.Text = "->> [Arcane]";
                        lbGrade2.ForeColor = Color.Purple;
                    }
                    Debug.WriteLine(old + " grade " + grade);

                    lbGradec.Text = "[Arcane] " + type;
                    lbGradec.ForeColor = Color.Purple;
                    break;
                case 5:
                    lbGradec.Text = "[Heroic] " + type;
                    lbGradec.ForeColor = Color.GreenYellow;
                    break;
                case 6:
                    lbGradec.Text = "[Unique] " + type;
                    lbGradec.ForeColor = Color.Orange;
                    break;
                case 7:
                    lbGradec.Text = "[Celestial] " + type;
                    lbGradec.ForeColor = Color.Red;
                    break;
                case 8:
                    lbGradec.Text = "[Divine] " + type;
                    lbGradec.ForeColor = Color.DarkOrange;
                    break;
                case 9:
                    lbGradec.Text = "[Epic] " + type;
                    lbGradec.ForeColor = Color.DimGray;
                    break;
                case 10:
                    lbGradec.Text = "[Legendary] " + type;
                    lbGradec.ForeColor = Color.Gold;
                    break;
                case 11:
                    lbGradec.Text = "[Mythic] " + type;
                    lbGradec.ForeColor = Color.DarkRed;
                    break;
            }
        }

        private void EnchantForm_Load(object sender, EventArgs e)
        {
            pbItem.BackColor = Color.Transparent;
            pbItem.Parent = pbGrade;
            pbItem.Location = Point.Empty;

            String item = RegradeOptions.itemType;
            int grade = MainForm.grade;
            pbItem.Image = Image.FromFile("images/grade"+grade+".png");
            pbGrade.Image = Image.FromFile("images/" + item + ".jpg");
        }

        private void EnchantForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
