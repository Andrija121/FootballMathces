using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMathces
{

    public partial class Form1 : Form
    {
        private FootballTeam ft;
    


        public Form1()
        {
            InitializeComponent();
            ft = new FootballTeam();
        }

        private void btnAddMatchResult_Click(object sender, EventArgs e)
           
        {
            listBox1.Items.Clear();
            int a = Convert.ToInt32(tbHomeScore.Text);
            int b = Convert.ToInt32(textBox1.Text);
            ft.AddMatch(tbHomeTeam.Text, tbAwayTeam.Text, a, b);
            foreach (var match in ft.GetMatches())
            {
                listBox1.Items.Add(match);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox4.Text != "")
                foreach (var match in ft.GetMatchesByTeam(textBox4.Text))
                {
                    listBox1.Items.Add(match);
                }
            else
            {
                foreach (var match in ft.GetMatches())
                {
                    listBox1.Items.Add(match);
                }
            }
            
        }
    }
}
