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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { 
                About aboutForm = new About();
                aboutForm.MdiParent = this;
                aboutForm.WindowState = FormWindowState.Maximized;
                aboutForm.Show();
        }
        private bool CheckIfFormCreated(Type formType)
        {
            bool formCreated = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    formCreated = true;
                    form.Activate();
                    break;
                }
            }

            return formCreated;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(NameSearch)))
            {
                NameSearch nameSearchForm = new NameSearch();
                nameSearchForm.MdiParent = this;
                nameSearchForm.WindowState = FormWindowState.Maximized;
                nameSearchForm.Show();
            }
        }

        private void ticTacToeMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(TicTacToe)))
            {
                TicTacToe ticTacToeForm = new TicTacToe();
                ticTacToeForm.MdiParent = this;
                ticTacToeForm.WindowState = FormWindowState.Maximized;
                ticTacToeForm.Show();
            }

        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(Slots)))
            {
                Slots slotsForm = new Slots();
                slotsForm.MdiParent = this;
                slotsForm.WindowState = FormWindowState.Maximized;
                slotsForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

