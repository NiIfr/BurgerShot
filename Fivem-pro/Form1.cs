using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Security;

namespace Fivem_pro
{
    public partial class Form1 : Form
    {
        int calc = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listSelect.SelectedIndex = 0;
        }



        private void addbtn_Click(object sender, EventArgs e)
        {
            string a = listSelect.SelectedItem.ToString();
            int number = ((int)numericUpDown1.Value);
            listV.Items.Add(a + " x " + number);

            switch (a)
            {
                case "Shot fries":
                    calc = 5 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "Shot ring":
                    calc = 5 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "Shot nugget":
                    calc = 5 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "Coffee":
                    calc = 5 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "Coke":
                    calc = 10 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "Water":
                    calc = 5 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "MilkShake":
                    calc = 15 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "Creampie":
                    calc = 5 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "RimJob":
                    calc = 5 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "MoneyShot":
                    calc = 15 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "HeartStopper":
                    calc = 20 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "TheBleeder":
                    calc = 15 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "MeatFree":
                    calc = 10 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "Torpedo":
                    calc = 15 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "GoatCheeseWrap":
                    calc = 10 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;
                case "CheeseWrap":
                    calc = 10 * number;
                    totallbl.Text = (int.Parse(totallbl.Text) + calc).ToString();
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
            numericUpDown1.Value = 1;


        }



        private void reset_Click(object sender, EventArgs e)
        {
            listV.Items.Clear();
            calc = 0;
            totallbl.Text = "0";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}