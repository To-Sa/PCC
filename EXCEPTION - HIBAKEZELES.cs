using System;
using System.Windows.Forms;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;

            try
            {
                a = int.Parse("3.5");
                MessageBox.Show("OK?");
            }
            catch (FormatException) //az összes hibát elkapjuk így 
            {
                MessageBox.Show("ERROR - I CAN NOT CONVERT IT!");
            }
            MessageBox.Show(a.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;

            a = int.Parse("3.5");

            MessageBox.Show("OK?");

            MessageBox.Show("ERROR - I CAN NOT CONVERT IT!");

            MessageBox.Show(a.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;

            try
            {
                a = int.Parse("");
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR - I CAN NOT CONVERT IT!");
            }
            catch (OverflowException ofe)
            {
                MessageBox.Show(ofe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            MessageBox.Show(a.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool err = true;
            do
            {
                string s = "";
                try
                {
                    s = "";
                    if (s.Length == 0) throw new Exception("NO TEXT");
                    err = false; //ide csak akkor jut el a vezérlés, ha nem lesz kivétel
                }
                catch (Exception NEVE)
                {
                    MessageBox.Show(NEVE.Message);
                }
            }
            while (err);

            MessageBox.Show("END"); //ez lefog futni 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 10;
                int b = 0;
                MessageBox.Show((a / b).ToString());
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("ERROR AGAIN no use: 0");
            }
            finally
            { //ez az ág mindenképpen lefut! 
                MessageBox.Show("END AGAIN");
            }
        }
    }
}
