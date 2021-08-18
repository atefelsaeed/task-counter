using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int counter=0;
        double hourCounter = 0;
        double calc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numberTask.Text = counter.ToString();
            houres.Text = hourCounter.ToString();
            calcLable.Text = calc.ToString();
              
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            counter += 1;
            numberTask.Text = counter.ToString();

            if (counter == 56)
            {
                hourCounter += 1;
                counter = 0;
                numberTask.Text = counter.ToString();
                houres.Text = hourCounter.ToString();
            }
            
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            counter -= 1;
            numberTask.Text = counter.ToString();
            if (counter <= 0) {
                counter = 0;
                numberTask.Text = counter.ToString();
            }
           

        }

        private void clearTask_Click(object sender, EventArgs e)
        {
            counter = 0;
            numberTask.Text = counter.ToString();
        }

       

        private void addHoure_Click(object sender, EventArgs e)
        {
            hourCounter += 1;
            houres.Text = hourCounter.ToString();
        }

        private void deleteHoure_Click(object sender, EventArgs e)
        {
            hourCounter -= 1;
            houres.Text = hourCounter.ToString();

            if (hourCounter <= 0)
            {
                hourCounter = 0;
                houres.Text = hourCounter.ToString();
            }
        }

        private void clearHoure_Click(object sender, EventArgs e)
        {
            hourCounter = 0;
            houres.Text = hourCounter.ToString();
        }

        private void houres_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (counter < 56)
            {
                calc =Math.Round((counter * 1.07)/60,2);
                hourCounter += calc;
                numberTask.Text = counter.ToString();
                houres.Text = hourCounter.ToString();
                calcLable.Text = calc.ToString();
            }
        }

        private void calcLable_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calc = 0;
            calcLable.Text = calc.ToString();
        }
    }
}
