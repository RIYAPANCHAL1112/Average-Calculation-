// Author:          Riya Panchal
// Date:            March 24, 2022
// Description:     This is lab 3 , here we enter 7 days entery of unit by there specific region and print their average 
//                  accouring to there region and in the end we will print the total average of all three regions

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {

        //Declaration of the number of regions and number of days.
        const int MaximumDays = 7;
        const int MaximumRegions = 3;
        const int MaximumUnits = 5000;

        //Declaration of array to contain all of inputs.
        int[,] units = new int[MaximumRegions, MaximumDays];

        //Declaration class-level variables for the current day and region
        int day = 0;
        int region = 0;

        //Declaration arrays of controls that exist for current day and region
        TextBox[] outputTextBoxes = new TextBox[MaximumRegions];
        Label[] outputAverageLabel = new Label[MaximumRegions];

        public Form1()
        {
            InitializeComponent();

            outputTextBoxes = new TextBox[] { textBoxRegion1, textBoxRegion2, textBoxRegion3 };
            outputAverageLabel = new Label[] { labelRegion1Average, labelRegion2Average, labelRegion3Average };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        public void SetDefaults()
        {
            //Reset the variable.
            day = 0;
            region = 0;

            //Re-enable any controls that may be disable.
            textBoxUnits.ReadOnly = false;
            buttonEnter.Enabled = true;

            //Clear any control that should be cleared.
            textBoxUnits.Clear();
            textBoxRegion1.Clear();
            textBoxRegion2.Clear();
            textBoxRegion3.Clear();
            labelRegion1Average.Text = String.Empty;
            labelRegion2Average.Text = String.Empty;
            labelRegion3Average.Text = String.Empty;
            labelAverage.Text = String.Empty;
            
            //Set focus.
            textBoxUnits.Focus();
        }


        #region EventHandlers

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int currentCases;

            //Check the entry in casesTextBox is whole number.
            if (int.TryParse(textBoxUnits.Text, out currentCases))
            {

                //Check the entry in casesTextBox is in range
                if (currentCases >= 0 && currentCases <= MaximumUnits)
                {
                    //If it's number in range, add it to the array and to the output text box for the current region
                    units[region, day] = currentCases;
                    outputTextBoxes[region].Text += currentCases + Environment.NewLine;
                  

                    //Increment the day by 1
                    day++;

                    //If the entry was valid and we are done day 7, determine the average for the current region 
                    if (day >= MaximumDays)
                    {
                        double avg = 0;
                        //Output average
                        if (region == 0)
                        {

                            //calculating the entries of textboxes
                            for (int index = 0; MaximumDays >= index; index++)
                            {
                                try
                                {
                                    avg += double.Parse(outputTextBoxes[region].Lines[index]);
                                }
                                catch
                                {
                                }
                            }

                            //showing the average of region 1
                            labelRegion1Average.Text = "Average: " + System.Math.Round((avg / MaximumDays), 2).ToString();
                        }
                        else if (region == 1)
                        {
                            //calculating the entries of textboxes
                            for (int index = 0; MaximumDays >= index; index++)
                            {
                                try
                                {
                                    avg += double.Parse(outputTextBoxes[region].Lines[index]);
                                }
                                catch
                                {
                                }
                            }

                            //showing the average of region 2
                            labelRegion2Average.Text = "Average: " + System.Math.Round((avg / MaximumDays), 2).ToString();

                        }
                        else if (region == 2)
                        {
                            //calculating the entries of textboxes
                            for (int index = 0; MaximumDays >= index; index++)
                            {
                                try
                                {
                                    avg += double.Parse(outputTextBoxes[region].Lines[index]);
                                }
                                catch
                                {
                                }
                            }

                            //showing the average of region 3
                            labelRegion3Average.Text = "Average: " + System.Math.Round((avg / MaximumDays), 2).ToString();

                        }


                        //Reset the day to 0 and increment the region by 1
                        day = 0;
                        region++;
                    }
                    

                    //If the entry was valid and we are done region 3, determine the overall average 
                    if (region == 3)
                    {
                        //Output average
                        double totalAvg = double.Parse(labelRegion1Average.Text.Substring(9)) +
                            double.Parse(labelRegion2Average.Text.Substring(9)) +
                            double.Parse(labelRegion3Average.Text.Substring(9));
                        labelAverage.Text = "Average this week: " + System.Math.Round(totalAvg / region, 2).ToString();

                        //Disable some controls and focus on the reset button
                        buttonEnter.Enabled = false;

                    }



                }
                //If the entry is not in range, put an error in a MessageBox.
                else
                {
                    MessageBox.Show("Value between 0 and  " + MaximumUnits + ".", "Entry Error!");
                }
            }
            //If the entry is not in whole Number, put an error in a MessageBox.
            else
            {
                MessageBox.Show("Value must be a whole number ", "Entry Error!");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //calling resetDefault function
            SetDefaults();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // close the whole program
            this.Close();
        }


        #endregion

    }
}
