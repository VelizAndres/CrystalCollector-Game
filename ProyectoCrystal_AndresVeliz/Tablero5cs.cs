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
    public partial class Tablero5cs : Form
    {
        //Declarar Clases
        Matriz M = new Matriz();
        Preguntas Preg = new Preguntas();
        //Declarar Variables
        object AvatarP;
        object Vacio;
        int x, y, GemaRec, MsM;
        int fila = 10;
        int columna = 10;
        int troll = 6;
        int diamante = 12;
        bool pass = false;
        //Declarar Variables que recibiran valores
        public int puntaje, vida, SelecAvatar, segundos;
        public string nombre;

        //Formato para imagen del datagrid
        private void DtgvTab_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.DtgvTab.Columns[e.ColumnIndex].Name)
            {
                case "C1":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C2":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C3":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C4":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C5":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C6":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C7":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C8":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C9":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "C10":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
            }

        }
        //Finaliza Formato datagrid

        //Boton de Terminar Partida
        private void btnFinish_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Resultado TabNext = new Resultado();
            puntaje = M.Jug.puntaje;
            labelPuntaje.Text = Convert.ToString(puntaje);
            //Mandar variables a la clase resultado
            TabNext.puntaje = puntaje;
            TabNext.SelecAvatar = SelecAvatar;
            TabNext.time = segundos;
            TabNext.nombre = nombre;
            TabNext.Activate();
            TabNext.Show();
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //Tiempo
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            Tiempo.Text = Convert.ToString((segundos / 60)) + " : " + (segundos % 60);
        }

        //Finaliza boton de terminar partida
        //Boton de comandos
        private void btnComan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A o Flecha a la izquierda=Un espacio a la izquierda\nD o Flecha a la derecha=Un espacio a la derecha\nW o Flecha hacia arriba=Un espacio arriba\nS o Flecha hacia abajo=Un espacio abajo\nQ=Dos a la izquierda\nE=Dos a la derecha", "Comandos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DtgvTab.Focus();
        }
        //Finaliza Boton de comandos

            //Inicia Evento del Datagrid Keyup
        private void DtgvTab_KeyUp(object sender, KeyEventArgs e)
        {
            //Validar si la tecla es W o flecha arriba
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                //Validación del rango
                if (x > 0)
                {
                    x = x - 1;
                    M.Celda[x + 1, y].Lleno = false;
                    //Validar si hay un diamante
                    if (DtgvTab[y, x].Value == M.Diamante)
                    {
                        GemaRec++;
                        M.Jug.Punteo(15);
                        puntaje = M.Jug.puntaje;
                        labelPuntaje.Text = Convert.ToString(puntaje);
                    }
                    //Valida si hay un troll
                    else if (DtgvTab[y, x].Value == M.Troll)
                    {
                        Preg.Question();
                        do
                        {
                            Preg.ShowDialog();
                        } while (Preg.Eleccion == 0);
                        if (Preg.Eleccion == Preg.Respuesta)
                        {
                            M.Jug.Punteo(10);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            M.Jug.Vidas(1);
                            vida = M.Jug.Vida;
                            labelvida.Text = Convert.ToString(vida);
                            M.MOVERRND(1);
                            DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                        }
                        else
                        {
                            M.Jug.Vidas(-1);
                            M.Jug.Punteo(-20);
                            puntaje = M.Jug.puntaje;
                            vida = M.Jug.Vida;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            Tablero4 TabAnt = new Tablero4();
                            TabAnt.nombre = nombre;
                            TabAnt.puntaje = puntaje;
                            TabAnt.vida = vida;
                            TabAnt.SelecAvatar = SelecAvatar;
                            MessageBox.Show("Perdio una vida y regresa un nivel", "Atención");
                            TabAnt.segundos = segundos;
                            TabAnt.Activate();
                            TabAnt.Show();
                            pass = true;
                        }
                    }
                    //Valida si hay un portal
                    else if (DtgvTab[y, x].Value == M.Portal)
                    {
                        //Validar si tiene todas las gemas
                        if (GemaRec == diamante)
                        {
                            Resultado TabNext = new Resultado();
                            M.Jug.Punteo(50);
                            M.Jug.Punteo(1000);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            TabNext.puntaje = puntaje;
                            TabNext.SelecAvatar = SelecAvatar;
                            TabNext.nombre = nombre;
                            TabNext.segundos = segundos;
                            TabNext.Activate();
                            TabNext.Show();
                            pass = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe recoger todas las gemas", "Error!");
                            M.Jug.Punteo(-5);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            M.MOVERRND(2);
                            DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                        }
                    }
                    if (pass == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        DtgvTab[y, x].Value = AvatarP;
                        if (DtgvTab[y, x + 1].Value != M.Portal & DtgvTab[y, x + 1].Value != M.Troll)
                        {
                            DtgvTab[y, x + 1].Value = Vacio;
                        }
                    }
                }
            }

            //Validar si la tecla es A o flecha Izquierda
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                //Valida el rango
                if (y > 0)
                {
                    y = y - 1;
                    M.Celda[x, y + 1].Lleno = false;
                    //Valida si hay una gema
                    if (DtgvTab[y, x].Value == M.Diamante)
                    {
                        GemaRec++;
                        M.Jug.Punteo(15);
                        puntaje = M.Jug.puntaje;
                        labelPuntaje.Text = Convert.ToString(puntaje);
                    }
                    //Valida si hay un trolll
                    else if (DtgvTab[y, x].Value == M.Troll)
                    {
                        Preg.Question();
                        do
                        {
                            Preg.ShowDialog();
                        } while (Preg.Eleccion == 0);
                        if (Preg.Eleccion == Preg.Respuesta)
                        {
                            M.Jug.Punteo(10);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            M.Jug.Vidas(1);
                            vida = M.Jug.Vida;
                            labelvida.Text = Convert.ToString(vida);
                            M.MOVERRND(1);
                            DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                        }
                        else
                        {
                            M.Jug.Vidas(-1);
                            M.Jug.Punteo(-20);
                            puntaje = M.Jug.puntaje;
                            vida = M.Jug.Vida;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            Tablero4 TabAnt = new Tablero4();
                            TabAnt.nombre = nombre;
                            TabAnt.puntaje = puntaje;
                            TabAnt.vida = vida;
                            TabAnt.SelecAvatar = SelecAvatar;
                            MessageBox.Show("Perdio una vida y regresa un nivel", "Atención");
                            TabAnt.segundos = segundos;
                            TabAnt.Activate();
                            TabAnt.Show();
                            pass = true;
                        }
                    }
                    //Valida si hay un portal
                    else if (DtgvTab[y, x].Value == M.Portal)
                    {
                        //Valida si tiene todas las gemas
                        if (GemaRec == diamante)
                        {
                            Resultado TabNext = new Resultado();
                            M.Jug.Punteo(50);
                            M.Jug.Punteo(1000);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            TabNext.puntaje = puntaje;
                            TabNext.SelecAvatar = SelecAvatar;
                            TabNext.nombre = nombre;
                            TabNext.segundos = segundos;
                            TabNext.Activate();
                            TabNext.Show();
                            pass = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe recoger todas las gemas", "Error!");
                            M.Jug.Punteo(-5);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            M.MOVERRND(2);
                            DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                        }
                    }
                    //Valida si debe cerrarse el form
                    if (pass == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        DtgvTab[y, x].Value = AvatarP;

                        if (DtgvTab[y + 1, x].Value != M.Portal & DtgvTab[y + 1, x].Value != M.Troll)
                        {
                            DtgvTab[y + 1, x].Value = Vacio;
                        }
                    }

                }

            }
            //Validar si la tecla es D o flecha derecha
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                //Valida si esta en el rango
                if (y < (columna - 1))
                {
                    y = y + 1;
                    M.Celda[x, y - 1].Lleno = false;
                    //Valida si hay una gema
                    if (DtgvTab[y, x].Value == M.Diamante)
                    {
                        GemaRec++;
                        M.Jug.Punteo(15);
                        puntaje = M.Jug.puntaje;
                        labelPuntaje.Text = Convert.ToString(puntaje);
                    }
                    //Valida si hay un troll
                    else if (DtgvTab[y, x].Value == M.Troll)
                    {
                        Preg.Question();
                        do
                        {
                            Preg.ShowDialog();
                        } while (Preg.Eleccion == 0);
                        if (Preg.Eleccion == Preg.Respuesta)
                        {
                            M.Jug.Punteo(10);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            M.Jug.Vidas(1);
                            vida = M.Jug.Vida;
                            labelvida.Text = Convert.ToString(vida);
                            M.MOVERRND(1);
                            DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                        }
                        else
                        {
                            M.Jug.Vidas(-1);
                            M.Jug.Punteo(-20);
                            puntaje = M.Jug.puntaje;
                            vida = M.Jug.Vida;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            Tablero4 TabAnt = new Tablero4();
                            TabAnt.nombre = nombre;
                            TabAnt.puntaje = puntaje;
                            TabAnt.vida = vida;
                            TabAnt.SelecAvatar = SelecAvatar;
                            MessageBox.Show("Perdio una vida y regresa un nivel", "Atención");
                            TabAnt.segundos = segundos;
                            TabAnt.Activate();
                            TabAnt.Show();
                            pass = true;
                        }
                    }
                    //Valida si hay un portal
                    else if (DtgvTab[y, x].Value == M.Portal)
                    {
                        //Validar si tiene todas las gemas
                        if (GemaRec == diamante)
                        {
                            Resultado TabNext = new Resultado();
                            M.Jug.Punteo(50);
                            M.Jug.Punteo(1000);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            TabNext.puntaje = puntaje;
                            TabNext.SelecAvatar = SelecAvatar;
                            TabNext.nombre = nombre;
                            TabNext.segundos = segundos;
                            TabNext.Activate();
                            TabNext.Show();
                            pass = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe recoger todas las gemas", "Error!");
                            M.Jug.Punteo(-5);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            M.MOVERRND(2);
                            DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                        }
                    }
                    //Valida si debe cerrarse el form
                    if (pass == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        DtgvTab[y, x].Value = AvatarP;
                        if (DtgvTab[y - 1, x].Value != M.Portal & DtgvTab[y - 1, x].Value != M.Troll)
                        {
                            DtgvTab[y - 1, x].Value = Vacio;
                        }
                    }

                }
            }
            //Validar si la tecla es S o flecha abajo
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                //Validar si esta dentro del rango
                if (x < (fila - 1))
                {
                    x = x + 1;
                    M.Celda[x - 1, y].Lleno = false;
                    //Valida si hay una gema
                    if (DtgvTab[y, x].Value == M.Diamante)
                    {
                        GemaRec++;
                        M.Jug.Punteo(15);
                        puntaje = M.Jug.puntaje;
                        labelPuntaje.Text = Convert.ToString(puntaje);
                    }
                    //Valida si hay un troll
                    else if (DtgvTab[y, x].Value == M.Troll)
                    {
                        Preg.Question();
                        do
                        {
                            Preg.ShowDialog();
                        } while (Preg.Eleccion == 0);
                        if (Preg.Eleccion == Preg.Respuesta)
                        {
                            M.Jug.Punteo(10);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            M.Jug.Vidas(1);
                            vida = M.Jug.Vida;
                            labelvida.Text = Convert.ToString(vida);
                            M.MOVERRND(1);
                            DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                        }
                        else
                        {
                            M.Jug.Vidas(-1);
                            M.Jug.Punteo(-20);
                            puntaje = M.Jug.puntaje;
                            vida = M.Jug.Vida;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            Tablero4 TabAnt = new Tablero4();
                            TabAnt.nombre = nombre;
                            TabAnt.puntaje = puntaje;
                            TabAnt.vida = vida;
                            TabAnt.SelecAvatar = SelecAvatar;
                            MessageBox.Show("Perdio una vida y regresa un nivel", "Atención");
                            TabAnt.segundos = segundos;
                            TabAnt.Activate();
                            TabAnt.Show();
                            pass = true;
                        }
                    }
                    //Valida si hay un portal
                    else if (DtgvTab[y, x].Value == M.Portal)
                    {
                        //Validar si tiene todas las gemas
                        if (GemaRec == diamante)
                        {
                            Resultado TabNext = new Resultado();
                            M.Jug.Punteo(50);
                            M.Jug.Punteo(1000);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            TabNext.puntaje = puntaje;
                            TabNext.SelecAvatar = SelecAvatar;
                            TabNext.nombre = nombre;
                            TabNext.segundos = segundos;
                            TabNext.Activate();
                            TabNext.Show();
                            pass = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe recoger todas las gemas", "Error!");
                            M.Jug.Punteo(-5);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            M.MOVERRND(2);
                            DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                        }
                    }
                    //Valida si debe cerrarse el form
                    if (pass == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        DtgvTab[y, x].Value = AvatarP;
                        if (DtgvTab[y, x - 1].Value != M.Portal & DtgvTab[y, x - 1].Value != M.Troll)
                        {
                            DtgvTab[y, x - 1].Value = Vacio;
                        }
                    }

                }
            }

            //Validar si es Q
            //Super Izquierda
            if (e.KeyCode == Keys.Q)
            {
                int mov = 0;
                //Valida el rango
                if (y > 1)
                {
                    //ciclo para repetir mov a la izquierda
                    do
                    {
                        y = y - 1;
                        M.Celda[x, y + 1].Lleno = false;
                        //Valida si hay una gema
                        if (DtgvTab[y, x].Value == M.Diamante)
                        {
                            GemaRec++;
                            M.Jug.Punteo(15);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                        }
                        //Valida si hay un trolll
                        else if (DtgvTab[y, x].Value == M.Troll)
                        {
                            Preg.Question();
                            do
                            {
                                Preg.ShowDialog();
                            } while (Preg.Eleccion == 0);
                            if (Preg.Eleccion == Preg.Respuesta)
                            {
                                M.Jug.Punteo(10);
                                puntaje = M.Jug.puntaje;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                M.Jug.Vidas(1);
                                vida = M.Jug.Vida;
                                labelvida.Text = Convert.ToString(vida);
                                M.MOVERRND(1);
                                DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                            }
                            else
                            {
                                M.Jug.Vidas(-1);
                                M.Jug.Punteo(-20);
                                puntaje = M.Jug.puntaje;
                                vida = M.Jug.Vida;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                Tablero4 TabAnt = new Tablero4();
                                TabAnt.nombre = nombre;
                                TabAnt.puntaje = puntaje;
                                TabAnt.vida = vida;
                                TabAnt.SelecAvatar = SelecAvatar;
                                MessageBox.Show("Perdio una vida y regresa un nivel", "Atención");
                                TabAnt.segundos = segundos;
                                TabAnt.Activate();
                                TabAnt.Show();
                                pass = true;
                            }
                        }
                        //Valida si hay un portal
                        else if (DtgvTab[y, x].Value == M.Portal)
                        {
                            //Valida si tiene todas las gemas
                            if (GemaRec == diamante)
                            {
                                Resultado TabNext = new Resultado();
                                M.Jug.Punteo(50);
                                M.Jug.Punteo(1000);
                                puntaje = M.Jug.puntaje;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                TabNext.puntaje = puntaje;
                                TabNext.SelecAvatar = SelecAvatar;
                                TabNext.nombre = nombre;
                                TabNext.segundos = segundos;
                                TabNext.Activate();
                                TabNext.Show();
                                pass = true;
                            }
                            else
                            {
                                MessageBox.Show("Debe recoger todas las gemas", "Error!");
                                M.Jug.Punteo(-5);
                                puntaje = M.Jug.puntaje;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                M.MOVERRND(2);
                                DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                            }
                        }
                        //Valida si debe cerrarse el form
                        if (pass == true)
                        {
                            this.Close();
                        }
                        else
                        {
                            DtgvTab[y, x].Value = AvatarP;

                            if (DtgvTab[y + 1, x].Value != M.Portal & DtgvTab[y + 1, x].Value != M.Troll)
                            {
                                DtgvTab[y + 1, x].Value = Vacio;
                            }
                        }
                        mov++;
                    } while (mov < 2 & pass == false);

                }

            }
            //Validar si es E
            //Super Derecha
            if (e.KeyCode == Keys.E)
            {
                int mov = 0;
                //Validar si esta en el rango
                if (y < (columna - 2))
                {
                    do
                    {
                        y = y + 1;
                        M.Celda[x, y - 1].Lleno = false;
                        //Valida si hay una gema
                        if (DtgvTab[y, x].Value == M.Diamante)
                        {
                            GemaRec++;
                            M.Jug.Punteo(15);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                        }
                        //Valida si hay un troll
                        else if (DtgvTab[y, x].Value == M.Troll)
                        {
                            Preg.Question();
                            do
                            {
                                Preg.ShowDialog();
                            } while (Preg.Eleccion == 0);
                            if (Preg.Eleccion == Preg.Respuesta)
                            {
                                M.Jug.Punteo(10);
                                puntaje = M.Jug.puntaje;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                M.Jug.Vidas(1);
                                vida = M.Jug.Vida;
                                labelvida.Text = Convert.ToString(vida);
                                M.MOVERRND(1);
                                DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                            }
                            else
                            {
                                M.Jug.Vidas(-1);
                                M.Jug.Punteo(-20);
                                puntaje = M.Jug.puntaje;
                                vida = M.Jug.Vida;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                Tablero4 TabAnt = new Tablero4();
                                TabAnt.nombre = nombre;
                                TabAnt.puntaje = puntaje;
                                TabAnt.vida = vida;
                                TabAnt.SelecAvatar = SelecAvatar;
                                MessageBox.Show("Perdio una vida y regresa un nivel", "Atención");
                                TabAnt.segundos = segundos;
                                TabAnt.Activate();
                                TabAnt.Show();
                                pass = true;
                            }
                        }
                        //Valida si hay un portal
                        else if (DtgvTab[y, x].Value == M.Portal)
                        {
                            //Validar si tiene todas las gemas
                            if (GemaRec == diamante)
                            {
                                Resultado TabNext = new Resultado();
                                M.Jug.Punteo(50);
                                M.Jug.Punteo(1000);
                                puntaje = M.Jug.puntaje;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                TabNext.puntaje = puntaje;
                                TabNext.SelecAvatar = SelecAvatar;
                                TabNext.nombre = nombre;
                                TabNext.segundos = segundos;
                                TabNext.Activate();
                                TabNext.Show();
                                pass = true;
                            }
                            else
                            {
                                MessageBox.Show("Debe recoger todas las gemas", "Error!");
                                M.Jug.Punteo(-5);
                                puntaje = M.Jug.puntaje;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                M.MOVERRND(2);
                                DtgvTab[M.col, M.fil].Value = M.Celda[M.fil, M.col].Imagen;
                            }
                        }
                        //Valida si debe cerrarse el form
                        if (pass == true)
                        {
                            this.Close();
                        }
                        else
                        {
                            DtgvTab[y, x].Value = AvatarP;
                            if (DtgvTab[y - 1, x].Value != M.Portal & DtgvTab[y - 1, x].Value != M.Troll)
                            {
                                DtgvTab[y - 1, x].Value = Vacio;
                            }
                        }
                        mov++;
                    } while (mov < 2 & pass == false);
                }
            }

            //Muestra los picturbox que contiene las gemas
            if (GemaRec > 0 & pass == false)
            {
                if (GemaRec >= 1)
                {
                    pbgema1.Visible = true;
                }

                if (GemaRec >= 2)
                {
                    pbgema2.Visible = true;
                }
                if (GemaRec >= 3)
                {
                    pbgema3.Visible = true;
                }
                if (GemaRec >= 4)
                {
                    pbgema4.Visible = true;
                }
                if (GemaRec >= 5)
                {
                    pbgema5.Visible = true;
                }
                if (GemaRec >= 6)
                {
                    pbgema6.Visible = true;
                }
                if (GemaRec >= 7)
                {
                    pbgema7.Visible = true;
                }
                if (GemaRec >= 8)
                {
                    pbgema8.Visible = true;
                }
                if (GemaRec >= 9)
                {
                    pbgema9.Visible = true;
                }
                if (GemaRec >= 10)
                {
                    pbgema10.Visible = true;
                }
                if (GemaRec >= 11)
                {
                    pbgema11.Visible = true;
                }
                if (GemaRec >= 12)
                {
                    pbgema12.Visible = true;
                    if (MsM == 0)
                    {
                        MessageBox.Show("Puede Avanzar al portal", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        MsM++;
                    }
                }
            }

            //Muestra la Ubicacion del Jugador
            if (pass == false)
            {
                labelUbi.Text = "(" + x + "," + y + ")";
            }
        }


        public Tablero5cs()
        {
            InitializeComponent();
        }
        //Boton Imprimir Tablero
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MsM = 0;
            DtgvTab.Enabled = true;
            DtgvTab.Focus();
            btnImprimir.Visible = false;
            DtgvTab.Rows.Add(fila);
            labelvida.Text = Convert.ToString(vida);
            labelPuntaje.Text = Convert.ToString(puntaje);
            //Asigna la altura a las filas
            for (int a = 0; a < fila; a++)
            {
                DtgvTab.Rows[a].Height = 642 / fila;
            }
            //Asigna las posiciones de los elementos
            M.Dimensiones(fila, columna);
            M.LlenarCeldasBlanco();
            M.LLenarDiamante(diamante);
            M.Trolls(troll);
            M.LlenarJug();
            M.AgregarPortal();

            //Asignar Valores a las coordenadas donde se encuentra el jugador
            for (int i = 0; i < columna; i++)
            {
                for (int j = 0; j < fila; j++)
                {
                    DtgvTab[i, j].Value = M.Celda[j, i].Imagen;

                    if (DtgvTab[i, j].Value == AvatarP)
                    {
                        y = i; x = j;
                    }
                }
            }
            GemaRec = 0;
            DtgvTab.ClearSelection();
            labelUbi.Text = "(" + x + "," + y + ")";
        }
        //Finaliza Boton imprimir tablero
        //Inicializa las variables, funciones y metodos cuando carga el form
        private void Tablero5cs_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Vacio = M.Vacio;
            btnImprimir.Focus();
            M.Jug.Imagen(SelecAvatar);
            AvatarP = M.Jug.Jugador;
            M.Jug.Vidas(vida);
            M.Jug.Punteo(puntaje);
            labelname.Text = nombre;
        }
        //Finaliza Carga del form
    }
}
