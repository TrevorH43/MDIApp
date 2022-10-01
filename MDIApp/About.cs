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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            richTextBox1.DetectUrls = true;
            richTextBox1.Enabled = false;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Annotations for Images Used:");
            sb.AppendLine();
            sb.AppendLine("All icons used were free images from https://iconscout.com/icons.");
            sb.AppendLine("Search icon, https://iconscout.com/icons/search was created by Iconscout Store.");
            sb.AppendLine("Game (Tic-Tac-Toe) icon, https://iconscout.com/icons/game, was created by Mohit Gandhi.");
            sb.AppendLine("Slot machine icon, https://iconscout.com/icons/slot-machine was created by Yaprativa.");
            richTextBox1.Text = sb.ToString();
        }
    }
}
