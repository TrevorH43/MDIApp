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
    public partial class TicTacToe : Form
    {
        Random rn = new Random();

        const int SIZE = 3;
        char[,] tile = new char[SIZE, SIZE];
        int i, j;

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            InitializeArrayAndResetLabelBackground();
            SetTileState();
        }
        private void InitializeArrayAndResetLabelBackground()
        {
            // Initialize the 2D array
            for (i = 0; i < SIZE; i++)
            {
                for (j = 0; j < SIZE; j++)
                {
                    tile[i, j] = ' ';
                }
            }

            SetTileState(true);
        }
        private void SetTileState(bool backgroundOnly = false)
        {
            

            // Iterate over the rows
            for (int i = 0; i < SIZE; i++)
            {
                // Iterate over the columns
                for (int j = 0; j < SIZE; j++)
                {
                    /* 
                        * This code is a bit tricky.  In order to store a value from the 2D array
                        * in a label, we need to determine the label number, i.e., label1 -label9.
                        * To do this we can use a formula:
                        * label number = (3 * row number) + column number + 1 we are using i as row and j as col.
                        * Once we know the label name we are trying to retrieve, we can search for it in the
                        * Controls collection.  The Controls collection will contain all the form controls that 
                        * have been added to the form.  The Controls.Find will return an array of the controls 
                        * that match the search condition.  In our case, we are using a specific label number,
                        * so only one should be returned.  Here we are using a Linq expression on the array,   
                        * FirstOrDefault, which should return only a single label.  In order to use the FirstOrDefault,
                        * requires a using statement for System.Linq.  Don't get too concerned about the Linq 
                        * expression, because we will be studying it later.
                        */
                    var label = FindLabel(i, j);
                    if (label != null)
                    {
                        if (backgroundOnly)
                            // resets background color of label to white
                            label.BackColor = Color.White;
                        else
                            // sets label text value
                            label.Text = tile[i, j].ToString();
                    }
                }
            }
        }

        private Control FindLabel(int row, int col)
        {
            int labelNo = (3 * row) + col + 1;
            return Controls.Find($"label{labelNo}", false).FirstOrDefault();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TicTacToe()
        {
            InitializeComponent();
        }
        public void setBackground((int, int) coord)
        {
            var row = coord.Item1;
            var col = coord.Item2;
            var label = FindLabel(row, col);
            if (label != null)
                label.BackColor = Color.LightYellow;
        }
        public void setValue(char playerValue)
        {
            bool done = false;
            while (!done)
            {
                // get a random number between 1 and 9 inclusive
                int value = rn.Next(1, 10);

                // Calculate the row, column values in the 2D array
                if (value < 4)
                    i = 0;
                else if (value < 7)
                    i = 1;
                else
                    i = 2;

                // formula to determine label number is 3*i + j + 1, so
                // we have value and we want to solve for j
                j = value - (3 * i) - 1;

                // determine if it has already been assigned a value
                // if it has, then we are going to go through the process yet again....
                if (tile[i, j] == ' ')
                {
                    // if it hasn't, the set the value in the cell and get out of loop
                    tile[i, j] = playerValue;
                    done = true;
                }
            }
        }
        public bool checkTileValuesForMatch((int, int) coord1, (int, int) coord2,
    (int, int) coord3, out char playerValue)
        {
            bool hasMatch = false;
            playerValue = ' ';

            // Retrieve the array values for the row/column combinations indicated by the tuples
            Char tile1 = tile[coord1.Item1, coord1.Item2];
            Char tile2 = tile[coord2.Item1, coord2.Item2];
            Char tile3 = tile[coord3.Item1, coord3.Item2];

            if ((tile1 != ' ' || tile2 != ' ' || tile3 != ' ') &&
                tile1 == tile2 && tile2 == tile3)
            {
                playerValue = tile1;
                hasMatch = true;

                // in order to have a visual, we will change the background of the tiles
                setBackground(coord1);
                setBackground(coord2);
                setBackground(coord3);
            }
            return hasMatch;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            char firstPlayer = ' ', secondPlayer = ' ';
            bool haveWinner = false;
            char playerValue;

            // Reset Game State
            InitializeArrayAndResetLabelBackground();
            messageLabel.Text = "";

            // Determine whether first player or second player is using 'X' or 'O'
            switch (rn.Next(9999) % 2)
            {
                case 0: firstPlayer = 'O'; secondPlayer = 'X'; break;
                case 1: firstPlayer = 'X'; secondPlayer = 'O'; break;
            }

            // there are a total of 9 labels to fill
            for (int count = 0; count < 9; count++)
            {
                playerValue = (count % 2 == 0) ? secondPlayer : firstPlayer;
                setValue(playerValue);

                // There is no sense trying to determine if someone won
                // until at least 5 plays have been completed 
                if (count >= 5)
                    haveWinner = checkForWinner(out playerValue);
                if (haveWinner)
                {
                    messageLabel.Text = $"{playerValue} Wins!";
                    break;
                }
            }

            if (!haveWinner)
                messageLabel.Text = "Tie occurred!";

            // Updates the labels with all values from the 2D array - using the default option in this parameter call
            SetTileState();
        }

        public bool checkForWinner(out char playerValue)
        {
            playerValue = ' ';

            // need to check combinations

            if (checkTileValuesForMatch((0, 0), (0, 1), (0, 2), out playerValue))
                return true;

            if (checkTileValuesForMatch((1, 0), (1, 1), (1, 2), out playerValue))
                return true;

            if (checkTileValuesForMatch((2, 0), (2, 1), (2, 2), out playerValue))
                return true;

            if (checkTileValuesForMatch((0, 0), (1, 0), (2, 0), out playerValue))
                return true;

            if (checkTileValuesForMatch((0, 1), (1, 1), (2, 1), out playerValue))
                return true;

            if (checkTileValuesForMatch((0, 2), (1, 2), (2, 2), out playerValue))
                return true;

            if (checkTileValuesForMatch((0, 0), (1, 1), (2, 2), out playerValue))
                return true;

            if (checkTileValuesForMatch((0, 2), (1, 1), (2, 0), out playerValue))
                return true;

            return false;
        }
    }
}
