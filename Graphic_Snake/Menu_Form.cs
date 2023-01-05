using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Graphic_Snake
{
    public partial class Menu_Form : Form
    {

        public static int poziomTrudnosci = 1;
        public static int snakeColor = 0;
        public static List<int> scores = new List<int>();
        public static List<string> players = new List<string>();


        //public static System.Windows.Media.MediaPlayer player = new System.Windows.Media.MediaPlayer();

        public Menu_Form()
        {
            InitializeComponent();




            //    player.MediaEnded += MediaEnded;
            //    player.Open(new Uri(@"C:\Users\Admin\source\repos\Graphic_Snake\SnakeSong.wav"));
            //    player.Play();
        }

        //}

        //    public void mediaended(object sender, eventargs e)
        //    {
        //        player.open(new uri(@"c:\users\admin\source\repos\graphic_snake\snakesong.wav"));
        //        player.play();
        //    }





        private void LoadGame(object sender, EventArgs e)

        {
            Gra_Form gameWindow = new Gra_Form();

            this.Hide();

            gameWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Ustawienia_Form settingsWindow = new Ustawienia_Form();

            this.Hide();

            settingsWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        public static bool FormIsOpen(FormCollection application, Type formType)
        {
            return Application.OpenForms.Cast<Form>().Any(openForm => openForm.GetType() == formType);
        }

        private void Author_Click(object sender, EventArgs e)
        {
            Autor_Form authorWindow = new Autor_Form();

            this.Hide();

            authorWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }

        }

        private void Table_Click(object sender, EventArgs e)
        {
            Wyniki_Form tableWindow = new Wyniki_Form();

            this.Hide();

            tableWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Autor_Form authorWindow = new Autor_Form();

            this.Hide();

            authorWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wyniki_Form tableWindow = new Wyniki_Form();

            this.Hide();

            tableWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NazwaGracza_Form tableWindow = new NazwaGracza_Form();

            this.Hide();

            tableWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ustawienia_Form settingsWindow = new Ustawienia_Form();

            this.Hide();

            settingsWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NazwaGracza_Form tableWindow = new NazwaGracza_Form();

            this.Hide();

            tableWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Autor_Form authorWindow = new Autor_Form();

            this.Hide();

            authorWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Wyniki_Form tableWindow = new Wyniki_Form();

            this.Hide();

            tableWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Ustawienia_Form settingsWindow = new Ustawienia_Form();

            this.Hide();

            settingsWindow.ShowDialog();

            if (!FormIsOpen(Application.OpenForms, typeof(Ustawienia_Form)))
            {
                this.Show();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}


