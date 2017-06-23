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
    public partial class MainForm : Form
    {
        public static int grade = 2;
        bool useCharm = false;
        bool useResp = false;
        bool useScroll = false;
        double cost = 0;
        double totalCost = 0;
        double charmChance = 0;
        double gradeChance = 40;
        bool useHack = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void regradeOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegradeOptions rngForm = new RegradeOptions();
            rngForm.Show();
        }

        private void bEnchant_MouseDown(object sender, MouseEventArgs e)
        {
            bEnchant.Image = Properties.Resources.button_click;
        }

        private void bEnchant_MouseUp(object sender, MouseEventArgs e)
        {
            bEnchant.Image = Properties.Resources.button;
        }

        private void pbWscroll_Click(object sender, EventArgs e)
        {
            /*1H Weapon
            2H Weapon
            Bow
            Shield*/
            String itemT = RegradeOptions.itemType;
            if (itemT == "1H Weapon")
            {
                pbScroll.Image = Properties.Resources.weapon_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "2H Weapon")
            {
                pbScroll.Image = Properties.Resources.weapon_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Bow")
            {
                pbScroll.Image = Properties.Resources.weapon_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Shield")
            {
                pbScroll.Image = Properties.Resources.weapon_normal;
                useResp = false;
                useScroll = true;
            }
        }

        private void pbRWscroll_Click(object sender, EventArgs e)
        {
            if (grade == 10)
            {
                MessageBox.Show("You can't go above mythic ... yet", "Enchant Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                String itemT = RegradeOptions.itemType;
                if (itemT == "1H Weapon")
                {
                    pbScroll.Image = Properties.Resources.weapon_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "2H Weapon")
                {
                    pbScroll.Image = Properties.Resources.weapon_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Bow")
                {
                    pbScroll.Image = Properties.Resources.weapon_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Shield")
                {
                    pbScroll.Image = Properties.Resources.weapon_resp;
                    useResp = true;
                    useScroll = false;
                }
            }
        }

        private void pbAscroll_Click(object sender, EventArgs e)
        {
            /*Head
            Chest
            Waist
            Wrist
            Hands
            Legs
            Feet*/
            String itemT = RegradeOptions.itemType;
            if (itemT == "Head")
            {
                pbScroll.Image = Properties.Resources.armor_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Chest")
            {
                pbScroll.Image = Properties.Resources.armor_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Waist")
            {
                pbScroll.Image = Properties.Resources.armor_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Wrist")
            {
                pbScroll.Image = Properties.Resources.armor_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Hands")
            {
                pbScroll.Image = Properties.Resources.armor_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Legs")
            {
                pbScroll.Image = Properties.Resources.armor_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Feet")
            {
                pbScroll.Image = Properties.Resources.armor_normal;
                useResp = false;
                useScroll = true;
            }
        }

        private void pbRAscroll_Click(object sender, EventArgs e)
        {
            if (grade == 10)
            {
                MessageBox.Show("You can't go above mythic ... yet", "Enchant Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String itemT = RegradeOptions.itemType;
                if (itemT == "Head")
                {
                    pbScroll.Image = Properties.Resources.armor_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Chest")
                {
                    pbScroll.Image = Properties.Resources.armor_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Waist")
                {
                    pbScroll.Image = Properties.Resources.armor_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Wrist")
                {
                    pbScroll.Image = Properties.Resources.armor_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Hands")
                {
                    pbScroll.Image = Properties.Resources.armor_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Legs")
                {
                    pbScroll.Image = Properties.Resources.armor_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Feet")
                {
                    pbScroll.Image = Properties.Resources.armor_resp;
                    useResp = true;
                    useScroll = false;
                }
            }
        }

        private void pbJscroll_Click(object sender, EventArgs e)
        {
            /*Ear
            Neck
            Finger */
            String itemT = RegradeOptions.itemType;
            if (itemT == "Ear")
            {
                pbScroll.Image = Properties.Resources.jewel_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Neck")
            {
                pbScroll.Image = Properties.Resources.jewel_normal;
                useResp = false;
                useScroll = true;
            }
            else if (itemT == "Finger")
            {
                pbScroll.Image = Properties.Resources.jewel_normal;
                useResp = false;
                useScroll = true;
            }
        }

        private void pbRJscroll_Click(object sender, EventArgs e)
        {
            if (grade == 10)
            {
                MessageBox.Show("You can't go above mythic ... yet", "Enchant Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String itemT = RegradeOptions.itemType;
                if (itemT == "Ear")
                {
                    pbScroll.Image = Properties.Resources.jewel_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Neck")
                {
                    pbScroll.Image = Properties.Resources.jewel_resp;
                    useResp = true;
                    useScroll = false;
                }
                else if (itemT == "Finger")
                {
                    pbScroll.Image = Properties.Resources.jewel_resp;
                    useResp = true;
                    useScroll = false;
                }
            }
        }

        private void pbGreen_Click(object sender, EventArgs e)
        {
            if (grade == 4)
            {
                pbCharm.Image = Properties.Resources.charm_green;
                charmChance = 1.75;
            }
        }

        private void pbBlue_Click(object sender, EventArgs e)
        {
            if (grade == 5)
            {
                pbCharm.Image = Properties.Resources.charm_blue;
                charmChance = 1.75;
            }
        }

        private void pbYellow_Click(object sender, EventArgs e)
        {
            if (grade <= 6)
            {
                pbCharm.Image = Properties.Resources.charm_yellow;
                charmChance = 1.5;
            }
        }

        private void pbSYellow_Click(object sender, EventArgs e)
        {
            pbCharm.Image = Properties.Resources.charm_s_yellow;
            charmChance = 1.5;
        }

        private void pbRed_Click(object sender, EventArgs e)
        {
            if (grade <= 6)
            {
                pbCharm.Image = Properties.Resources.charm_red;
                charmChance = 2;
            }
        }

        private void pbSRed_Click(object sender, EventArgs e)
        {
            pbCharm.Image = Properties.Resources.charm_s_red;
            charmChance = 2;
        }

        private void pbWhite_Click(object sender, EventArgs e)
        {
            if (grade >= 7)
            {
                pbCharm.Image = Properties.Resources.charm_silver_white;
                charmChance = 2.5;
            }
        }

        void changeChange(double gra)
        {
            if (gra == 0)
            {
                //Grade: Basic
                gradeChance = 70;
            }
            else if (gra == 1)
            {
                //Grade: Grand
                gradeChance = 40;
            }
            else if (gra == 2)
            {
                //Grade: Rare
                gradeChance = 30;
            }
            else if (gra == 3)
            {
                //Grade: Arcane
                gradeChance = 30;
            }
            else if (gra == 4)
            {
                //Grade: Heroic
                //Old: scroll = 30;
                gradeChance = 25;
            }
            else if (gra == 5)
            {
                //Grade: Unique
                //Old: scroll = 25;
                gradeChance = 20;
            }
            else if (gra == 6)
            {
                //Grade: Celestial
                gradeChance = 10;
            }
            else if (gra == 7)
            {
                //Grade: Divine
                gradeChance = 7.5;
            }
            else if (gra == 8)
            {
                //Grade: Epic"
                gradeChance = 5;
            }
            else if (gra == 9)
            {
                //Grade: Legendary
                gradeChance = 2.5;
            }
        }

        private void bEnchant_Click(object sender, EventArgs e)
        {

            changeChange(grade);
            Random rnd = new Random();
            int random = rnd.Next(1,100);
            double r_gradeChance = gradeChance * 0.8;
            double r_gradeChance_n = gradeChance * 0.2;
            double f_d_chance = (gradeChance - 100) * 0.5;
            //double d_chance = gradeChance - 100;
            int status = 0;
            int oldGrade = grade;
            //Debug.WriteLine(r_gradeChance);
            String itemT = RegradeOptions.itemType;
            if (itemT != null && (useResp == true || useScroll == true))
            {
                if (grade >= 0 && grade < 11)
                {
                    if (useResp == true)
                    {
                        if (useHack == true)
                        {
                            oldGrade = grade - 2;
                            grade += 2;
                            status = 2;
                        }
                        else
                        {
                            //if charm is used
                            if (useCharm == true)
                            {
                                gradeChance = gradeChance * charmChance;
                            }
                            //calculation of success
                            if (random >= 0 && random <= gradeChance - r_gradeChance_n)
                            {
                                oldGrade = grade - 1;
                                grade += 1;
                                status = 1;
                            }
                            else if (random > gradeChance - r_gradeChance_n && random <= gradeChance)
                            {
                                oldGrade = grade - 2;
                                grade += 2;
                                status = 2;
                            }
                            else if ((random > gradeChance && random > gradeChance + f_d_chance) && grade == 7)
                            {
                                oldGrade = grade + 2;
                                grade -= 3;
                                status = 0;
                            }
                            else if (random > gradeChance && grade > 7)
                            {
                                grade = 2;
                                status = 3;
                                pbItemtype.Image = null;
                                itemT = null;
                            }
                        }
                        pbGrade.Image = Image.FromFile("images/grade" + grade + ".png");
                    }
                    else if (useResp == false)
                    {
                        if (useHack == true)
                        {
                            oldGrade = grade - 1;
                            grade += 1;
                            status = 1;
                        }
                        else
                        {
                            if (useCharm == true)
                            {
                                gradeChance = gradeChance * charmChance;
                            }
                            if (random >= 0 && random <= gradeChance)
                            {
                                oldGrade = grade - 1;
                                grade += 1;
                                status = 1;
                            }
                            else if ((random > gradeChance && random > gradeChance + f_d_chance) && grade == 7)
                            {
                                oldGrade = grade + 3;
                                grade -= 3;
                                status = 0;
                            }
                            else if (random > gradeChance && grade > 7)
                            {
                                grade = 2;
                                status = 3;
                                pbItemtype.Image = null;
                                itemT = null;
                            }
                        }
                        Debug.WriteLine("oldgrade: " + oldGrade);
                        Debug.WriteLine("grade: " + grade);
                        pbGrade.Image = Image.FromFile("images/grade" + grade + ".png");
                    }
                    /*int width = 48;
                    int height = 48;
                    Image image = new Bitmap(width, height);

                    using (var graphics = Graphics.FromImage(image))
                    {
                        graphics.DrawImage(Image.FromFile("images/" + itemT + ".jpg"), new Rectangle(0, 0, width, height));
                        graphics.DrawImage(Image.FromFile("images/grade" + grade + ".png"), new Rectangle(0, 0, width, height));
                    }

                    pbTest.SizeMode = PictureBoxSizeMode.Zoom;
                    pbTest.Image = image;*/
                    pbCharm.Image = null;
                    pbScroll.Image = null;
                    EnchantForm encForm = new EnchantForm(status,grade,itemT,oldGrade);
                    encForm.Show();
                    useScroll = false;
                    useResp = false;
                } else {
                    MessageBox.Show("You can't go above mythic ... yet","Enchant Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            } else {
                MessageBox.Show("You must first select a weapon from the 'Options' -> 'Regrade Options' and a scroll from the images","Enchant Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            String itemT = RegradeOptions.itemType;
            if (itemT == "1H Weapon")
            {
                pbItemtype.Image = Image.FromFile("images/" + itemT + ".jpg");
            }
            else if (itemT == "2H Weapon")
            {
                pbItemtype.Image = Image.FromFile("images/" + itemT + ".jpg");
            }
            else if (itemT == "Bow")
            {
                pbItemtype.Image = Image.FromFile("images/" + itemT + ".jpg");
            }
            else if (itemT == "Shield")
            {
                pbItemtype.Image = Image.FromFile("images/" + itemT + ".jpg");
            }
            /*int width = 48;
            int height = 48;
            Image image = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(image))
            {
                graphics.DrawImage(Image.FromFile("images/" + itemT + ".jpg"), new Rectangle(0, 0, width, height));
                graphics.DrawImage(Image.FromFile("images/grade" + grade + ".png"), new Rectangle(0, 0, width, height));
            }

            pbTest.SizeMode = PictureBoxSizeMode.Zoom;
            pbTest.Image = image;*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pbGrade.Image = Image.FromFile("images/grade" + grade + ".png");
            pbGrade.BackColor = Color.Transparent;
            pbGrade.Parent = pbItemtype;
            pbGrade.Location = Point.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double test = 968070;
            string s = test.ToString();
            string result = "";
            while (s.Length > 0)
            {
                if (result.Length > 0)
                    result += "       ";
                result += s.Substring(0, s.Length > 1 ? 2 : 1);
                s = s.Substring(s.Length > 1 ? 2 : 1);
            }
            label1.Text = "Cost: " + result;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            double WScroll = RegradeOptions.weaponS;
            double Charm = RegradeOptions.yellowC;
            cost = WScroll + Charm;
            /*string s = cost.ToString();
            string result = "";
            while (s.Length > 0)
            {
                if (result.Length > 0)
                    result += "       ";
                result += s.Substring(0, s.Length > 1 ? 2 : 1);
                s = s.Substring(s.Length > 1 ? 2 : 1);
            }*/

            /*var s = string.Join(string.Empty,
                    cost.ToString()
                         .Select((c, i) => i % 2 == 0 && i != 0 ? $"       {c}" : $"{c}"));*/
            //hot
            /*string s = Convert.ToString(cost);
            string x = String.Join("   ",
                Enumerable.Range(0, s.Length).Where(i => i % 2 == 0)
                .Select(i => s.Substring(0, s.Length - 4) + "       " + s.Substring(s.Length - 4, 2) + "       " + s.Substring(s.Length - 2)));*/

            /*string s ="1234567";
            string x = String.Join("   ",
                Enumerable.Range(0, s.Length).Where(i => i % 2 == 0)
                .Select(s.Length <= 2 ? s :
                     (s.Length <= 4 ? s.Substring(0, s.Length - 2) + " " + s.Substring(s.Length - 2) :
                        s.Substring(0, s.Length - 4) + " " + s.Substring(s.Length - 4, 2) + " " + s.Substring(s.Length - 2))));*/
           
            //var name = Convert.ToString(cost);
            /*var name = "123456789";
            var sub = name.Substring(5);
            var sub2 = name.Split();
            label4.Text = sub2;*/

            label4.Text = "" + cost;
            label5.Text = "" + cost;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            grade = 2;
            pbScroll.Image = null;
            useScroll = false;
            pbCharm.Image = null;
            useCharm = false;
            pbGrade.Image = Image.FromFile("images/grade" + grade + ".png");
        }

        private void useHackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (useHack == true)
            {
                useHack = false;
            }else
            {
                useHack = true;
            }
        }
    }
}
