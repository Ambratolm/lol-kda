using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LolKda
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            numUD_kills.TextChanged += (s, e) => Evaluate();
            numUD_deaths.TextChanged += (s, e) => Evaluate();
            numUD_assists.TextChanged += (s, e) => Evaluate();

            numUD_kills.ValueChanged += (s, e) => Evaluate();
            numUD_deaths.ValueChanged += (s, e) => Evaluate();
            numUD_assists.ValueChanged += (s, e) => Evaluate();
        }

        private void Evaluate()
        {
            int k = (int)numUD_kills.Value;
            int d = (int)numUD_deaths.Value;
            int a = (int)numUD_assists.Value;
            double kda = (k + a) / Math.Max(1, d);
            string feedback = "";

            if (k + d + a == 0)
            {
                feedback = "Likely inactive or AFK...";
                return;
            }

            if (kda == 0)
            {
                feedback = "Helpless feeder! Go AFK!";
            }
            else if (kda < 1)
            {
                feedback = "Pathetic noob! Having lag?";
            }
            else if (kda < 2)
            {
                feedback = "Not bad! Better could be done.";
            }
            else if (kda < 5)
            {
                feedback = "Good! Likely carried.";
            }
            else
            {
                feedback = "Great! Absolutly carried. GG EZ!";
            }

            textBox_kda.Text = kda.ToString();
            textBox_feedback.Text = feedback;
        }
    }
}
