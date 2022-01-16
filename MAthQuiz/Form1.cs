using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAthQuiz
{
    public partial class Form1 : Form
    {
        Random aliatoire = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int val1;
        int val2;
        int mend, subend, diference;
        int prod1, prod2, resu;
        int defend, devisor, re;
        int temp;
        public Form1()
        {
            InitializeComponent();
        }

        public void commencer()
        {
           
            val1 = aliatoire.Next(51);
            val2 = aliatoire.Next(51);
            
            mend = aliatoire.Next(1, 101);
            subend = aliatoire.Next(1, mend);

            prod1 = aliatoire.Next(2, 11);
            prod2=aliatoire.Next(2, 11);

            defend = aliatoire.Next(2, 11);
            int temporaryQuotient = aliatoire.Next(2, 11);
            devisor = defend * temporaryQuotient;


            plusLeftLabel.Text = val1.ToString();
            plusRightLabel.Text = val2.ToString();

            minusLeftLabel.Text = mend.ToString();
            minusRightLabel.Text = subend.ToString();
            
            timesLeftLabel.Text = prod1.ToString();
            timesRightLabel.Text = prod2.ToString();
           
            dividedLeftLabel.Text = defend.ToString();
            dividedRightLabel.Text = devisor.ToString();


            sum.Value = 0;
            difference.Value = 0;
            product.Value = 0;
            quotient.Value = 0;




            temp = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool checkAnswer()
        {
            if ((val1 + val2 == sum.Value)
                && (mend - subend == difference.Value)
                && (prod1 * prod2 == product.Value)
                && (defend / devisor == quotient.Value)
               )
                return true;
            else
                return false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click_Click(object sender, EventArgs e)
        {
            commencer();
            startButton_Click.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkAnswer())
            {
               
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton_Click.Enabled = true;
            }
            if (temp > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                temp = temp - 1;
                timeLabel.Text = temp + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = val1 + val2;
                difference.Value = mend - subend;
                product.Value = prod1 * prod2;
                quotient.Value = defend / devisor;
                startButton_Click.Enabled = true;
            }
        }
        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }
       


        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
