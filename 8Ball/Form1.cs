using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Ball
{


    public partial class Form1 : Form
    {
        Random randGen = new Random();
        


        public Form1()
        {
            InitializeComponent();

            
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            //random number variable
            int randomNumber;
            randomNumber = randGen.Next(1, 7);
           
            
            //random output
            switch (randomNumber)
                {
               case 1:
                    outputLabel.Text = "NO!!!!";
                        break;
                case 2:
                    outputLabel.Text = "Definitely not";
                    break;
                case 3:
                    outputLabel.Text = "Yes";
                    break;
                case 4:
                    outputLabel.Text = "Very doudtful";
                    break;
                case 5:
                    outputLabel.Text = "Don't Count on it";
                    break;
                case 6:
                    outputLabel.Text = "Sighs point to yes";
                    break;
            }

        }
    }
}
