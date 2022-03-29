using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracTest1
{
    public partial class Form1 : Form
    {
        //Name:
        //ID:

        //The cost of a single 0.75 carat diamond
        const decimal DIAMOND_COST = 1200;
        //The cost of 1 gram of 24K gold
        const decimal GOLD_COST = 55.34m;
        //The profit margin (150%)
        const double PROFIT_MARGIN = 0.8;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void claculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARE VARIABLES
                int diamondsUsed;
                int goldUsed;

                decimal costOfDiamonds;
                decimal costOfGold;

                decimal baseCost;
                decimal marginValue;
                decimal finalCost;

                //PARSE INPUT VALUES
                diamondsUsed = int.Parse(diamondTextBox.Text);
                goldUsed = int.Parse(goldTextBox.Text);
               
                //CALCULATE INPUT
                costOfDiamonds = diamondsUsed * DIAMOND_COST;
                costOfGold = goldUsed * GOLD_COST;
                baseCost = costOfDiamonds + costOfGold;
                marginValue = baseCost + (decimal)PROFIT_MARGIN;
                finalCost = baseCost + marginValue;

                //DISPLAY OUTPUT VALUES
                diamondCostTextBox.Text = costOfDiamonds.ToString("c");
                goldCostTextBox.Text = costOfGold.ToString("c");
                baseCostTextBox.Text =baseCost.ToString("c");
                finalCostTextBox.Text = finalCost.ToString("c");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            diamondTextBox.Clear();
            goldTextBox.Clear();
            goldCostTextBox.Clear();
            diamondCostTextBox.Clear();
            baseCostTextBox.Clear();
            finalCostTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
