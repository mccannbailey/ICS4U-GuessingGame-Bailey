using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();
        }

        private void ResultsScreen_Load(object sender, EventArgs e)
        {
            resultLabel.Location = new Point(this.Width / 2 - 100, 30);
            resultLabel.Text = "Here are your results:";

            guessnumLabel.Text = Convert.ToString(Form1.userGuesses.Count); // number of guesses
            
            var origOrder = string.Join(",", Form1.userGuesses.ToArray());  // create original list of strings to display
            guesslistLabel.Text = "Original order:  " + origOrder;          

            Form1.userGuesses.Sort();
            var sortOrder = string.Join(",", Form1.userGuesses.ToArray());  // create sorted list of strings to display
            sortedLabel.Text = "Sorted order:  " + sortOrder;  
        }

        private void button1_Click(object sender, EventArgs e)      // play again method, clear list
        {
            Form1.userGuesses.Clear();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();   // return to mainscreen
            f.Controls.Add(ms);            

            this.Refresh();
        }
    }
}
