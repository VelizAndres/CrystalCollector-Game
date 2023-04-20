using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCrystal_AndresVeliz
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Se crea una histancia para mostrar el main principal
            Form1 Menu = new Form1();
            Menu.Show();
            //Evita que se cierra la apliación cuando se cierra el form
           Application.Run();
        }
    }
}
