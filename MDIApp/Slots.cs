using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApp
{
    public partial class Slots : Form
    {
        Random rand = new Random();
        int n1, n2, n3;
        double deposit = 0, totalWin = 0;

        private void spinButton_Click(object sender, EventArgs e)
        {
            double prize = 0;

            GetImages();

            deposit += int.Parse(amountInsertedTextBox.Text);

            if (n1 == n2 && n2 == n3)
            {
                prize = int.Parse(amountInsertedTextBox.Text) * 2;
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                prize = int.Parse(amountInsertedTextBox.Text) * 2;
            }

            totalWin += prize;
            MessageBox.Show("You win " + prize.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You inserted " + deposit.ToString("c") + " and you have won " + totalWin.ToString("c"));
            this.Close();
        }

        public Slots()
        {
            InitializeComponent();
        }
        private void Slots_Load(object sender, EventArgs e)
        {
            GetImages();
        }
        private void GetImages()
        {
            n1 = rand.Next(imageList1.Images.Count);
            n2 = rand.Next(imageList1.Images.Count);
            n3 = rand.Next(imageList1.Images.Count);

            pictureBox1.Image = imageList1.Images[n1];
            pictureBox2.Image = imageList1.Images[n2];
            pictureBox3.Image = imageList1.Images[n3];
        }
    }
}

