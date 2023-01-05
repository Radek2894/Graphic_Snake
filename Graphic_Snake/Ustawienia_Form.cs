using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Snake
{
    public partial class Ustawienia_Form : Form
    {
        public Ustawienia_Form()
        {
            InitializeComponent();

            poziomTrudnosci.SelectedIndexChanged += new System.EventHandler(Set_Level);
            poziomTrudnosci.SelectedIndex = Menu_Form.poziomTrudnosci;




            snakeColor.SelectedIndexChanged += new System.EventHandler(Set_SnakeColor);
            snakeColor.SelectedIndex = Menu_Form.snakeColor;




        }



        private void Set_Level(object sender, System.EventArgs e)
        {
            Menu_Form.poziomTrudnosci = poziomTrudnosci.SelectedIndex;
        }

        private void Set_SnakeColor(object sender, System.EventArgs e)
        {
            Menu_Form.snakeColor = snakeColor.SelectedIndex;
        }



        private void saveButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void volume_Scroll(object sender, EventArgs e)
        {
           // Menu_Form.player.Volume = (float)music.Value / 10;
        }
    }
}



