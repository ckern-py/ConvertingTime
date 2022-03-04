using System;
using System.Windows.Forms;

namespace ConvertTime
{
    public partial class TimeConversionGUI : Form
    {
        //vars being used, may move a few more up here
        private string startUnit = "seconds";
        private string endUnit = "seconds";
        private Calculation unitToTimeSpan = new Calculation();
        private TimeSpan valueInTimeSpan;
        private string returnedAdvanced;
        private double conversionTime;

        public TimeConversionGUI()
        {
            InitializeComponent();
            this.Text = "Convert Time";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Seconds radio button in Origin Units
            //selecting changes words under input field
            startUnit = "seconds";
            RadioButton rb1 = sender as RadioButton;
            if (rb1.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Minutes radio button in Origin Units
            //selecting changes words under input field
            startUnit = "minutes";
            RadioButton rb2 = sender as RadioButton;
            if (rb2.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Hours radio button in Origin Units
            //selecting changes words under input field
            startUnit = "hours";
            RadioButton rb3 = sender as RadioButton;
            if (rb3.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Days radio button in Origin Units
            //selecting changes words under input field
            startUnit = "days";
            RadioButton rb4 = sender as RadioButton;
            if (rb4.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Weeks radio button in Origin Units
            //selecting changes words under input field
            startUnit = "weeks";
            RadioButton rb5 = sender as RadioButton;
            if (rb5.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //Years radio button in Origin Units
            //selecting changes words under input field
            startUnit = "years";
            RadioButton rb6 = sender as RadioButton;
            if (rb6.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            //Seconds radio button in Conversion Units
            //selecting changes words under input field
            endUnit = "seconds";
            RadioButton rb12 = sender as RadioButton;
            if (rb12.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            //Minutes radio button in Conversion Units
            //selecting changes words under input field
            endUnit = "minutes";
            RadioButton rb11 = sender as RadioButton;
            if (rb11.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            //Hours radio button in Conversion Units
            //selecting changes words under input field
            endUnit = "hours";
            RadioButton rb10 = sender as RadioButton;
            if (rb10.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            //Days radio button in Conversion Units
            //selecting changes words under input field
            endUnit = "days";
            RadioButton rb9 = sender as RadioButton;
            if (rb9.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //Weeks radio button in Conversion Units
            //selecting changes words under input field
            endUnit = "weeks";
            RadioButton rb8 = sender as RadioButton;
            if (rb8.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //Years radio button in Conversion Units
            //selecting changes words under input field
            endUnit = "years";
            RadioButton rb7 = sender as RadioButton;
            if (rb7.Checked)
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate in format selected
            string userEnteredNumber = textBox1.Text;

            if (Double.TryParse(userEnteredNumber, out double enteredTime))
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
            else
            {
                label4.Text = "Please enter a number to convert";
                return;
            }

            try
            {
                valueInTimeSpan = unitToTimeSpan.ConvertInputToTimeSpan(enteredTime, startUnit);
            }
            catch (OverflowException)
            {
                label4.Text = "TimeSpan overflow, please try again.";
                return;
            }

            conversionTime = unitToTimeSpan.ConversionOfUnits(valueInTimeSpan, endUnit);
            label5.Text = conversionTime.ToString();
            label6.Text = String.Format("{0}", endUnit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculate in YY:WW:DD:HH:MM:SS
            //below is same as calculate button, come back and streamline
            string userEnteredNumber = textBox1.Text;

            if (Double.TryParse(userEnteredNumber, out double enteredTime))
            {
                label4.Text = String.Format("Converting from {0} to {1}", startUnit, endUnit);
            }
            else
            {
                label4.Text = "Please enter a number to convert";
                return;
            }

            try
            {
                valueInTimeSpan = unitToTimeSpan.ConvertInputToTimeSpan(enteredTime, startUnit);
            }
            catch (OverflowException)
            {
                label4.Text = "TimeSpan overflow, please try again.";
                return;
            }

            //above can be stream lined
            returnedAdvanced = unitToTimeSpan.CalculateAdvanced(valueInTimeSpan, endUnit);
            label5.Text = returnedAdvanced;
            label6.Text = ""; // String.Format("{0}", endUnit);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Just says "Answer:"
            //Probably not going to change
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //This probably doesn change just says 
            //Enter a number to convert
            //or something like that 
            //maybe could remove this? not sure how it all works
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //User enters number to calculate here 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Convert from units radio button group
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //Convert to units radio button group
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //list units for conversion, from startUnit to endUnit
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //I dont think this is used or needed
            //accidently added and dont know how to safely delete
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //where answer should be displayed, only the double
            //text for unit will go in another location 
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //where answer should be displayed, only the double
            //text for unit will go in another location
        }
    }
}
