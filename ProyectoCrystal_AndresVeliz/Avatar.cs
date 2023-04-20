using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrystal_AndresVeliz
{
    struct Avatar
    {
        //Atributos del avatar
        public string Nombre;
        public int Vida;
        public object Jugador;
        public int puntaje;
        //Asignar nombre
        public void AsignarNombre(string name)
        {
            Nombre = name;
        }
        //Puntaje
        public void Punteo(int pt)
        {
            puntaje += pt;
        }
        //Asignar o quitar vidas
        public void Vidas(int life)
        {
            Vida = Vida + life;
        }
        //Asignar apariencia
        public void Imagen(int i)
        {
            switch(i)
            {
                case 1:
                    Jugador = @"Imagenes\Ironman.png";
                    break;
                case 2:
                    Jugador = @"Imagenes\Flash.png";
                    break;
                case 3:
                    Jugador = @"Imagenes\Spiderman.jpg";
                    break;
                case 4:
                    Jugador = @"Imagenes\Superman.png";
                    break;
                case 5:
                    Jugador = @"Imagenes\Capitan.png";
                    break;
                case 6:
                    Jugador = @"Imagenes\Batman.jpg";
                    break;
            }
        }
        //Finaliza Asignar Apariencia
    }
}
