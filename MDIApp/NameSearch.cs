using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApp
{
    public partial class NameSearch : Form
    {
        List<string> girlsNamesList = new List<string>();
        List<string> boysNameList = new List<string>();

        public NameSearch()
        {
            InitializeComponent();
        }

        private void NameSearch_Load(object sender, EventArgs e)
        {
            girlsNamesList = loadListFromFile("GirlNames.txt");
            boysNameList = loadListFromFile("BoyNames.txt");
        }
        private List<string> loadListFromFile(String fileName)
        {
            List<string> nameList = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        nameList.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show(e.Message);
            }

            return nameList;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var boyExistsQualifier = boysNameList.Contains(boyNameTextBox.Text) ? "" : "not a ";
            var girlExistsQualifier = girlsNamesList.Contains(girlNameTextBox.Text) ? "" : "not a ";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{boyNameTextBox.Text} is {boyExistsQualifier}a popular boy name.");
            sb.AppendLine($"{girlNameTextBox.Text} is {girlExistsQualifier}a popular girl name.");
            resultsLabel.Text = sb.ToString();
        }
    }
}