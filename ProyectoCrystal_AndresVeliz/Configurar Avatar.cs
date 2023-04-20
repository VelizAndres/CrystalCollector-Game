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
    public partial class Configurar_Avatar : Form
    {
        //Instanciar el primer tablero
        Tablero1 Tab = new Tablero1();
        public Configurar_Avatar()
        {
            InitializeComponent();
        }
        //Inicia Proceso para asignar apariencia al avatar
        private void btnAvatar_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text != "")
            {
                Tab.SelecAvatar = 1;
                Tab.vida = 3;
                Tab.puntaje = 0;
                Tab.nombre=txtboxNombre.Text;
                Tab.Activate();
                Tab.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Error!");
                txtboxNombre.Focus();
            }
            }

        private void btnAvatar2_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text != "")
            {
                Tab.SelecAvatar = 2;
                Tab.vida = 3;
                Tab.puntaje = 0;
                Tab.nombre=txtboxNombre.Text;
                Tab.Activate();
                Tab.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Error!");
                txtboxNombre.Focus();
            }

        }

        private void btnAvatar3_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text != "")
            {
                Tab.SelecAvatar = 3;
                Tab.vida = 3;
                Tab.puntaje = 0;
                Tab.nombre=txtboxNombre.Text;
                Tab.Activate();
                Tab.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Error!");
                txtboxNombre.Focus();
            }

        }

        private void btnAvatar4_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text != "")
            {
                Tab.SelecAvatar = 4;
                Tab.vida = 3;
                Tab.puntaje = 0;
                Tab.nombre=txtboxNombre.Text;
                Tab.Activate();
                Tab.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Error!");
                txtboxNombre.Focus();
            }

        }

        private void btnAvatar5_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text != "")
            {
                Tab.SelecAvatar = 5;
                Tab.vida = 3;
                Tab.puntaje = 0;
                Tab.nombre=txtboxNombre.Text;
                Tab.Activate();
                Tab.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Error!");
                txtboxNombre.Focus();
            }

        }

        private void btnAvatar6_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text != "")
            {
                Tab.SelecAvatar = 6;
                Tab.vida = 3;
                Tab.puntaje = 0;
                Tab.nombre=txtboxNombre.Text;
                Tab.Activate();
                Tab.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Error!");
                txtboxNombre.Focus();
            }

        }
        //Finaliza Proceso para asignar apariencia al avatar
        //Textbox para el nombre
        private void txtboxNombre_TextChanged(object sender, EventArgs e)
        {

        }
        //Finaliza el boton de proceso
        //Boton regresar al menú principal
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form Menu = new Form1();
            Menu.Show();
            this.Close();
        }
        //Finaliza boton regresar
    }
}
