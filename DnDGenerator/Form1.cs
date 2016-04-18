using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDGenerator
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int[] Scores = new int[6];
            int counter = 0;

            while(counter < 6)
            {
                Scores[counter] = GenerateScores();

                if(Scores[counter] >= 10)
                {
                    counter++;
                }
            }


            label1.Text = Convert.ToString(Scores[0]);
            label2.Text = Convert.ToString(Scores[1]);
            label3.Text = Convert.ToString(Scores[2]);
            label4.Text = Convert.ToString(Scores[3]);
            label5.Text = Convert.ToString(Scores[4]);
            label6.Text = Convert.ToString(Scores[5]);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private int GenerateScores()
        {
            

            int[] randomNumbers = new int[4];
            randomNumbers[0] = rand.Next(0, 7);
            randomNumbers[1] = rand.Next(0, 7);
            randomNumbers[2] = rand.Next(0, 7);
            randomNumbers[3] = rand.Next(0, 7);



            Array.Sort(randomNumbers);

            int randSum = randomNumbers[1] + randomNumbers[2] + randomNumbers[3];

            return randSum;
        }

       
    }
}
