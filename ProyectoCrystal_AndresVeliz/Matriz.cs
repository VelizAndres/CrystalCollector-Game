using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrystal_AndresVeliz
{
    class Matriz
    {
        //Declarar clase en matriz
        public Casilla[,] Celda;
        //Declarar Clase avatar
        public Avatar Jug = new Avatar();
        //Asignar Valores a los objetos para llenar la matriz
        public object Vacio = @"Imagenes\Vacio.jpg";
        public object Troll = @"Imagenes\TrollNV.jpg";
        public object Diamante = @"Imagenes\Gema.jpg";
        public object Portal = @"Imagenes\Portal.jpg";
        //Si se quiere mostrar el troll, se cambia TrollNV por Troll
        Random Aleatorio = new Random();
        int fila, columna;
        public int fil, col;

        //Asignar Dimensiones
        public void Dimensiones(int numfi, int numcol)
        {
            fila = numfi;
            columna = numcol;
           Celda= new Casilla[fila, columna];
        }

        //LLenar la matriz de espacios vacios
        public void LlenarCeldasBlanco()
        {
            for (int fil = 0; fil < fila; fil++)
            {
                for (int col = 0; col < columna; col++)
                {
                      Celda[fil, col].Imagen = Vacio;
                }
            }
        }
        
        //Agregar jugador
        public void LlenarJug()
        {
            int posible = 0;
            do
            {
                int fil = Aleatorio.Next(0, fila);
                int col = Aleatorio.Next(0, columna);
                if (Celda[fil, col].Lleno == false)
                {
                    Celda[fil, col].Imagen = Jug.Jugador;
                    Celda[fil, col].Lleno = true;
                    posible++;
                }
            } while (posible < 1);
        }
        
        //Agregar Portal
        public void AgregarPortal()
        {
            int posible = 0;
            do
            {
                int fil = Aleatorio.Next(0, fila);
                int col = Aleatorio.Next(0, columna);
                if (Celda[fil, col].Lleno == false)
                {
                    Celda[fil, col].Imagen = Portal;
                    Celda[fil, col].Lleno = true;
                    posible++;
                }
            } while (posible < 1);
        }
        
        //Llenar de trolls
        public void Trolls(int lim)
        {
            int troll = 1;
            do{
                int fil = Aleatorio.Next(0, fila);
                int col = Aleatorio.Next(0, columna);

                if (Celda[fil, col].Lleno == false)
                {
                    Celda[fil, col].Imagen = Troll;
                    Celda[fil, col].Lleno = true;
                    troll++;
                }
            } while (troll <= lim);
        }
        
        //Llenar Gemas
        public void LLenarDiamante(int lim)
        {
            int Diaman = 1;
            do
            {
               int posible=0;
                int pass = 0;
                int fil = Aleatorio.Next(0, fila);
                int col = Aleatorio.Next(0, columna);
                if (Celda[fil, col].Lleno == false)
                {
                    if(fil==0)
                    {
                        if (col == 0)
                        {
                            posible = 2;
                        }
                        if(col==columna-1)
                        {
                            posible = 2;
                        }
                        else
                        {
                            posible = 3;
                        }
                    }
                    else if (fil == fila-1)
                    {
                        if (col == 0)
                        {
                            posible = 2;
                        }
                        if (col == columna-1)
                        {
                            posible = 2;
                        }
                        else
                        {
                            posible = 3;
                        }
                    }
                   else  if (col == columna-1)
                    {
                        if (fil == 0)
                        {
                            posible = 2;
                        }
                        if (fil == fila-1)
                        {
                            posible = 2;
                        }
                        else
                        {
                            posible = 3;
                        }
                    }
                   else  if (col == 0)
                    {
                        if (fil == 0)
                        {
                            posible = 2;
                        }
                        if (fil == fila-1)
                        {
                            posible = 2;
                        }
                        else
                        {
                            posible = 3;
                        }
                    }
                    else if(col>0 ||fil>0 ||col<columna-1||fil<fila-1)
                    {
                        posible = 4;
                    }

                    if (fil > 0)
                    {
                        if (Celda[fil - 1, col].Imagen != Diamante)
                        {
                            pass++;
                        }
                    }
                    if(col>0)
                    {
                        if(Celda[fil, col - 1].Imagen != Diamante)
                        {
                            pass++;
                        }
                    }
                    if (fil < (fila-1))
                    {
                        if (Celda[fil + 1, col].Imagen != Diamante)
                        {
                            pass++;
                        }
                    }
                    if(col<(columna-1))
                    {
                        if(Celda[fil, col + 1].Imagen != Diamante)
                        {
                            pass++;
                        }
                    }
                    if(pass==posible)
                    {
                        Celda[fil, col].Imagen = Diamante;
                        Celda[fil, col].Lleno = true;
                       Diaman++;
                    }
                }
            } while (Diaman <= lim);
        }
        //Finaliza LLenado de gemas
        //Mover de nuevo 
        public void MOVERRND(int i)
        {
            int posible = 0;
            do
            {
                 fil = Aleatorio.Next(0, fila);
                 col = Aleatorio.Next(0, columna);
                if (Celda[fil, col].Lleno == false)
                {
                    if(i==1)
                    {
                        Celda[fil, col].Imagen = Troll;
                    }
                    else
                    {
                        Celda[fil, col].Imagen = Portal;
                    }
                    Celda[fil, col].Lleno = true;
                    posible++;
                }
            } while (posible < 1);
        }






    }
}
