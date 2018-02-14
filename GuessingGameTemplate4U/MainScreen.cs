using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGameTemplate4U
{
    public partial class MainScreen : UserControl
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        int rand = 1;//randNum.Next(1, 101);
        int guess;

        Boolean numTrue = false;    // variable to determine what to run if the input is not an integer

        public MainScreen()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            outputLabel.ForeColor = Color.White;

            try // try to convert input
            {
                guess = Convert.ToInt16(inputBox.Text);
                numTrue = true;
            }
            catch   // if input is not an integer run this
            {
                outputLabel.ForeColor = Color.Red;
                outputLabel.Text = "Please enter a number";
                Refresh();
                Thread.Sleep(1000);

                numTrue = false;
            }
            
            Form1.userGuesses.Add(guess);
            
            if (guess < rand && numTrue)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand && numTrue)
            {
                outputLabel.Text = "Too High!";
            }
            else if (guess == rand && numTrue)
            {
                outputLabel.Text = "You Got it!";
                Refresh();
                Thread.Sleep(1000);

                Form f = this.FindForm();
                f.Controls.Remove(this);
             
                ResultsScreen rs = new ResultsScreen();
                f.Controls.Add(rs);
                this.Refresh();
            }

            numTrue = false;
            inputBox.Text = "";
            inputBox.Focus();
        }

    }
}
