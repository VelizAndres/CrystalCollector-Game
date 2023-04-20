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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Boton para salir del juego
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Exit función para cerrar la apliación
            Application.Exit();
        }
        //Finaliza Boton salir
        //Inicia Boton Iniciar
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Instanciar el form de configurar avatar
            Form ConfiAvatar = new Configurar_Avatar();
            ConfiAvatar.Show();
            this.Close();
        }
        //Finaliza Boton iniciar partida
        //Inicia Boton Información
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cristal Collector es un juego diseñado por el Ingeniero en Informática y sistema Diego Andrés Véliz Arauz,\n" +
                            "utilizando el lenguaje de programación de C# en el entorno de Visual Studio. El proyecto requirió de la investigación previa sobre el mercado de juegos,\n" +
                            "para determinar que temas son más populares en el entorno. Determinando que los superhéroes son muy populares.\nAgradeciendo a todos los colaboradores.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnIniciar.Focus();
        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
 MessageBox.Show("El juego consiste en utilizar las teclas para realizar desplazarse en el tablero.\n " +
     "Debe recolectar todas las gemas.\n Cuando se topa con un troll este le hará una pregunta con cuatro posibles respuestas.\n " +
     "El portal es accesible en cualquier momento, pero debe tener todas las gemas para poder avanzar de nivel.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnIniciar.Focus();
        }
        //Finaliza Boton Informacion

    }
}
