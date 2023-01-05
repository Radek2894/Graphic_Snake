using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Snake
{
    public partial class Wyniki_Form : Form
    {
        public Wyniki_Form()
        {

            InitializeComponent();
            switch (Menu_Form.players.Count)
            {
                case 1:
                    NameBox1.Text = Menu_Form.players[0]; ScoreBox1.Text = " " + Menu_Form.scores[0];
                    NameBox1.Visible = true;
                    ScoreBox1.Visible = true;
                    break;
                case 2:
                    NameBox1.Text = Menu_Form.players[0]; ScoreBox1.Text = " " + Menu_Form.scores[0];
                    NameBox1.Visible = true; ScoreBox1.Visible = true;
                    NameBox2.Text = Menu_Form.players[1]; ScoreBox2.Text = " " + Menu_Form.scores[1];
                    NameBox2.Visible = true; ScoreBox2.Visible = true;
                    break;
                case 3:
                    NameBox1.Text = Menu_Form.players[0]; ScoreBox1.Text = " " + Menu_Form.scores[0];
                    NameBox1.Visible = true; ScoreBox1.Visible = true;
                    NameBox2.Text = Menu_Form.players[1]; ScoreBox2.Text = " " + Menu_Form.scores[1];
                    NameBox2.Visible = true; ScoreBox2.Visible = true;
                    NameBox3.Text = Menu_Form.players[2]; ScoreBox3.Text = " " + Menu_Form.scores[2];
                    NameBox3.Visible = true; ScoreBox3.Visible = true;
                    break;
                case 4:
                    NameBox1.Text = Menu_Form.players[0]; ScoreBox1.Text = " " + Menu_Form.scores[0];
                    NameBox1.Visible = true; ScoreBox3.Visible = true;
                    NameBox2.Text = Menu_Form.players[1]; ScoreBox2.Text = " " + Menu_Form.scores[1];
                    NameBox2.Visible = true; ScoreBox2.Visible = true;
                    NameBox3.Text = Menu_Form.players[2]; ScoreBox3.Text = " " + Menu_Form.scores[2];
                    NameBox3.Visible = true; ScoreBox3.Visible = true;
                    NameBox4.Text = Menu_Form.players[3]; ScoreBox4.Text = " " + Menu_Form.scores[3];
                    NameBox4.Visible = true; ScoreBox4.Visible = true;
                    break;
                case 5:
                    NameBox1.Text = Menu_Form.players[0]; ScoreBox1.Text = " " + Menu_Form.scores[0];
                    NameBox1.Visible = true; ScoreBox1.Visible = true;
                    NameBox2.Text = Menu_Form.players[1]; ScoreBox2.Text = " " + Menu_Form.scores[1];
                    NameBox2.Visible = true; ScoreBox2.Visible = true;
                    NameBox3.Text = Menu_Form.players[2]; ScoreBox3.Text = " " + Menu_Form.scores[2];
                    NameBox3.Visible = true; ScoreBox3.Visible = true;
                    NameBox4.Text = Menu_Form.players[3]; ScoreBox4.Text = " " + Menu_Form.scores[3];
                    NameBox4.Visible = true; ScoreBox4.Visible = true;
                    NameBox5.Text = Menu_Form.players[4]; ScoreBox5.Text = " " + Menu_Form.scores[4];
                    NameBox5.Visible = true; ScoreBox5.Visible = true;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

