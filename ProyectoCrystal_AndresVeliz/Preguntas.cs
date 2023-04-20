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
    public partial class Preguntas : Form
    {
        //Variables de preguntas
        public int Respuesta;
        public int Eleccion;
        public int vida;
        public Preguntas()
        {
            InitializeComponent();
        }
        //Asignación de variables, de forma Random
        public void Question()
        {
            Eleccion = 0;
            Random Rnd = new Random();
            switch (Rnd.Next(1,10))
            {
                case 1:
                    LabelPregun.Text = "¿Cuál es el ave nacional de Guatemala?";
                    btnRes1.Text = "Aguila";
                    btnRes2.Text = "Quetzal";
                    btnRes3.Text = "Avestruz";
                    btnRes4.Text = "Paloma";
                    Respuesta = 2;
                    break;
                case 2:
                    LabelPregun.Text = "¿Cuál no es un número romano?";
                    btnRes1.Text = "V";
                    btnRes2.Text = "CX";
                    btnRes3.Text = "XX";
                    btnRes4.Text = "IIII";
                    Respuesta = 4;
                    break;
                case 3:
                    LabelPregun.Text = "¿Cuál es la fórmula del área de un triangulo?";
                    btnRes1.Text = "Base * Altura";
                    btnRes2.Text = "Lado al cubo";
                    btnRes3.Text = "(Base * Altura)/2";
                    btnRes4.Text = "(Lado * Lado)/2";
                    Respuesta = 3;
                    break;
                case 4:
                    LabelPregun.Text = "¿Cuál es la fórmula del área de un triangulo?";
                    btnRes1.Text = "Base * Altura";
                    btnRes2.Text = "Lado al cubo";
                    btnRes3.Text = "(Base * Altura)/2";
                    btnRes4.Text = "(Lado * Lado)/2";
                    Respuesta = 3;
                    break;
                case 5:
                    LabelPregun.Text = "¿Cuántas gemas del infinitos existen en el UCM?";
                    btnRes1.Text = "6";
                    btnRes2.Text = "7";
                    btnRes3.Text = "8";
                    btnRes4.Text = "2";
                    Respuesta = 1;
                    break;
                case 6:
                    LabelPregun.Text = "¿Qué es una variable?";
                    btnRes1.Text = "Una letra";
                    btnRes2.Text = "Un dato desconocido";
                    btnRes3.Text = "Un número";
                    btnRes4.Text = "Una operación";
                    Respuesta = 2;
                    break;
                case 7:
                    LabelPregun.Text = "¿Quién es T'Challa?";
                    btnRes1.Text = "Black Phanter";
                    btnRes2.Text = "Thor";
                    btnRes3.Text = "Falcon";
                    btnRes4.Text = "War Machine";
                    Respuesta = 1;
                    break;
                case 8:
                    LabelPregun.Text = "¿Qué es una fracción?";
                    btnRes1.Text = "Números";
                    btnRes2.Text = "Decimales";
                    btnRes3.Text = "Partes Iguales de un todo";
                    btnRes4.Text = "Partes Iguales de dos objetos";
                    Respuesta = 3;
                    break;
                case 9:
                    LabelPregun.Text = "¿Cuál es el valor de x?\nX*5=125";
                    btnRes1.Text = "15";
                    btnRes2.Text = "20";
                    btnRes3.Text = "6";
                    btnRes4.Text = "25";
                    Respuesta = 4;
                    break;
                case 10:
                    LabelPregun.Text = "¿Cuál es el valor de x?\n(X-5)/5=125";
                    btnRes1.Text = "24";
                    btnRes2.Text = "20";
                    btnRes3.Text = "6";
                    btnRes4.Text = "25";
                    Respuesta = 1;
                    break;
            }
        }
        //Termina Asignación de variables de preguntas

        private void Preguntas_Load(object sender, EventArgs e)
        {
        }
        //Boton para elegir la respuesta  
        private void btnRes1_Click(object sender, EventArgs e)
        {
            Eleccion = 1;
            if (Respuesta == Eleccion)
            {
                MessageBox.Show("Respondio Bien");
            }
            else
            {
                MessageBox.Show("Respondio Mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vida = -1;
            }
            this.Close();
        }
        private void btnRes3_Click(object sender, EventArgs e)
        {
            Eleccion = 3;
            if (Respuesta == Eleccion)
            {
                MessageBox.Show("Respondio Bien");
            }
            else
            {
            MessageBox.Show("Respondio Mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vida = -1;
            }
            this.Close();
        }
        private void btnRes2_Click(object sender, EventArgs e)
        {
            Eleccion = 2;
            if (Respuesta == Eleccion)
            {
                MessageBox.Show("Respondio Bien");
            }
            else
            {
                MessageBox.Show("Respondio Mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vida = -1;
            }
            this.Close();
        }
        private void btnRes4_Click(object sender, EventArgs e)
        {
            Eleccion = 4;
            if (Respuesta == Eleccion)
            {
                MessageBox.Show("Respondio Bien");
            }
            else
            {
                MessageBox.Show("Respondio Mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vida = -1;
            }
            this.Close();
        }
        //Finaliza boton para elegir la respuesta
    }
}

