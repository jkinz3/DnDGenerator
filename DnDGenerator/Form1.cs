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

        static int[] TrueScores = new int[6];
        int[] Scores = new int[6];
        static double[] Modifiers = new double[6];
        bool isDone;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
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

        private void label8_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem == comboBox1.SelectedItem)
            {
                comboBox2.SelectedItem = null;
            }
            if (comboBox3.SelectedItem == comboBox1.SelectedItem)
            {
                comboBox3.SelectedItem = null;
            }
            if (comboBox4.SelectedItem == comboBox1.SelectedItem)
            {
                comboBox4.SelectedItem = null;
            }
            if (comboBox5.SelectedItem == comboBox1.SelectedItem)
            {
                comboBox5.SelectedItem = null;
            }
            if (comboBox6.SelectedItem == comboBox1.SelectedItem)
            {
                comboBox6.SelectedItem = null;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                comboBox1.SelectedItem = null;
            }
            if (comboBox3.SelectedItem == comboBox2.SelectedItem)
            {
                comboBox3.SelectedItem = null;
            }
            if (comboBox4.SelectedItem == comboBox2.SelectedItem)
            {
                comboBox4.SelectedItem = null;
            }
            if (comboBox5.SelectedItem == comboBox2.SelectedItem)
            {
                comboBox5.SelectedItem = null;
            }
            if (comboBox6.SelectedItem == comboBox2.SelectedItem)
            {
                comboBox6.SelectedItem = null;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox3.SelectedItem)
            {
                comboBox1.SelectedItem = null;
            }
            if (comboBox2.SelectedItem == comboBox3.SelectedItem)
            {
                comboBox2.SelectedItem = null;
            }
            if (comboBox4.SelectedItem == comboBox3.SelectedItem)
            {
                comboBox4.SelectedItem = null;
            }
            if (comboBox5.SelectedItem == comboBox3.SelectedItem)
            {
                comboBox5.SelectedItem = null;
            }
            if (comboBox6.SelectedItem == comboBox3.SelectedItem)
            {
                comboBox6.SelectedItem = null;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox4.SelectedItem)
            {
                comboBox1.SelectedItem = null;
            }
            if (comboBox2.SelectedItem == comboBox4.SelectedItem)
            {
                comboBox2.SelectedItem = null;
            }
            if (comboBox3.SelectedItem == comboBox4.SelectedItem)
            {
                comboBox3.SelectedItem = null;
            }
            if (comboBox5.SelectedItem == comboBox4.SelectedItem)
            {
                comboBox5.SelectedItem = null;
            }
            if (comboBox6.SelectedItem == comboBox4.SelectedItem)
            {
                comboBox6.SelectedItem = null;
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox5.SelectedItem)
            {
                comboBox1.SelectedItem = null;
            }
            if (comboBox2.SelectedItem == comboBox5.SelectedItem)
            {
                comboBox2.SelectedItem = null;
            }
            if (comboBox3.SelectedItem == comboBox5.SelectedItem)
            {
                comboBox3.SelectedItem = null;
            }
            if (comboBox4.SelectedItem == comboBox5.SelectedItem)
            {
                comboBox4.SelectedItem = null;
            }
            if (comboBox6.SelectedItem == comboBox5.SelectedItem)
            {
                comboBox6.SelectedItem = null;
            }

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox6.SelectedItem)
            {
                comboBox1.SelectedItem = null;
            }
            if (comboBox2.SelectedItem == comboBox6.SelectedItem)
            {
                comboBox2.SelectedItem = null;
            }
            if (comboBox3.SelectedItem == comboBox6.SelectedItem)
            {
                comboBox3.SelectedItem = null;
            }
            if (comboBox4.SelectedItem == comboBox6.SelectedItem)
            {
                comboBox4.SelectedItem = null;
            }
            if (comboBox5.SelectedItem == comboBox6.SelectedItem)
            {
                comboBox5.SelectedItem = null;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool anyNull = true;
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null )
            {
                anyNull = false;
            }
            if(anyNull == true)
            {
                YouMust.Text = "You must make sure you have all ability scores selected! Make sure none are empty!";
            }
            if(anyNull == false && label1.Text != "RandomNumber")
            {
                YouMust.Text = null;

                for (int i = 0; i < 6; i++)
                {
                    TrueScores[i] = Scores[i];
                    Modifiers[i] = GenerateModifiers(TrueScores[i]);
                }

                label13.Text = Convert.ToString(Modifiers[0]);
                label14.Text = Convert.ToString(Modifiers[1]);
                label15.Text = Convert.ToString(Modifiers[2]);
                label16.Text = Convert.ToString(Modifiers[3]);
                label17.Text = Convert.ToString(Modifiers[4]);
                label18.Text = Convert.ToString(Modifiers[5]);

                isDone = true;
            }
            



        }

        private double GenerateModifiers(int score)
        {
            double tmpMod = (score - 10) / 2;
            double modifier = Math.Floor(tmpMod);
            return modifier;     
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
