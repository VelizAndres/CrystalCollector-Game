using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCrystal_AndresVeliz
{
    public partial class Resultado : Form
    {
        public int puntaje, SelecAvatar, minutos;
        public string nombre;
        public int segundos, time;
 

        public Resultado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Menu = new Form1();
            Menu.Show();
            this.Close();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            minutos = Convert.ToInt32(segundos / 60);
            time = (segundos % 60);
            labeltime.Text =Convert.ToString( minutos + ":" + time);
            labelname.Text = nombre;
            labelPuntaje.Text = Convert.ToString(puntaje);
            Image Jugador= null;
                switch (SelecAvatar)
                {
                    case 1:
                    Jugador = Properties.Resources.Ironman;
                        break;
                    case 2:
                    Jugador = Properties.Resources.Flash;
                        break;
                    case 3:
                    Jugador = Properties.Resources.Spiderman;
                        break;
                    case 4:
                    Jugador = Properties.Resources.Superman;
                    break;
                    case 5:
                        Jugador = Properties.Resources.Capitan;
                        break;
                    case 6:
                    Jugador = Properties.Resources.Batman;
                    break;
                }
            picturboxAvatar.BackgroundImage = Jugador;
        }
    }
}
