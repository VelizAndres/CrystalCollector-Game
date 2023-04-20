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
    public partial class Tablero1 : Form
    {
        //Declarar Clases
        Matriz M = new Matriz();
        Preguntas Preg = new Preguntas();
        //Declarar variables
        object AvatarP;
        object Vacio;
        int x, y, GemaRec, MsM;
        int fila = 3;
        int columna = 4;
        int diamante = 4;
        bool pass = false;
        //Declarar Variables que recibiran valores
        public int puntaje, vida, SelecAvatar,segundos;
        public string nombre;

        public Tablero1()
        {
            InitializeComponent();
        }
      
        //Boton de comandos
        private void btnComan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A o Flecha a la izquierda=Un espacio a la izquierda\nD o Flecha a la derecha=Un espacio a la derecha\nW o Flecha hacia arriba=Un espacio arriba\nS o Flecha hacia abajo=Un espacio abajo\nQ=Dos a la izquierda\nE=Dos a la derecha", "Comandos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            DtgvTab.Focus();
        }
        //Finaliza Boton de comandos

        //Boton de terminar partida
        private void btnFinish_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Resultado TabNext = new Resultado();
            puntaje = M.Jug.puntaje;
            labelPuntaje.Text = Convert.ToString(puntaje);
            //Mandar variables a la clase resultado
            TabNext.segundos = segundos;
            TabNext.puntaje = puntaje;
            TabNext.SelecAvatar = SelecAvatar;
            TabNext.nombre = nombre;
            TabNext.Activate();
            TabNext.Show();
            this.Close();
        }
        //Finaliza boton terminar partida
        
        //Tiempo
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            Tiempo.Text = Convert.ToString((segundos / 60)) + " : " + (segundos % 60);
        }
        //Finaliza Tiempo

        //Inicia evento de datagrid keyup
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
                    //Validar si hay un portal
                    else if (DtgvTab[y, x].Value == M.Portal)
                    {
                        //Validar si tiene todas las gemas
                        if (GemaRec == diamante)
                        {
                            Tablero2 TabNext = new Tablero2();
                            M.Jug.Punteo(50);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            TabNext.vida = vida;
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
                    //Validación para determinar si cierra el form
                    if (pass == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        DtgvTab[y, x].Value = AvatarP;
                        if (DtgvTab[y, x + 1].Value != M.Portal)
                        {
                            DtgvTab[y, x + 1].Value = Vacio;
                        }
                    }
                }
            }
            //Validar si la tecla es A o flecha izquierda
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                //Validar Rango
                if (y > 0)
                {
                    y = y - 1;
                    M.Celda[x, y + 1].Lleno = false;
                    //Valida si hay un diamante
                    if (DtgvTab[y, x].Value == M.Diamante)
                    {
                        GemaRec++;
                        M.Jug.Punteo(15);
                        puntaje = M.Jug.puntaje;
                        labelPuntaje.Text = Convert.ToString(puntaje);
                    }
                    //Validar si hay un portal
                    else if (DtgvTab[y, x].Value == M.Portal)
                    {
                        //Valida si tiene todas las gemas
                        if (GemaRec == diamante)
                        {
                            Tablero2 TabNext = new Tablero2();
                            M.Jug.Punteo(50);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            TabNext.vida = vida;
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
                        if (DtgvTab[y + 1, x].Value != M.Portal)
                        {
                            DtgvTab[y + 1, x].Value = Vacio;
                            M.Celda[x, y + 1].Lleno = false;
                        }
                    }

                }

            }
            //Validar si la tecla es D o flecha derecha
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                //Validar si esta en el rango
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
                    //Valida si hay un portal
                    else if (DtgvTab[y, x].Value == M.Portal)
                    {
                        //Valida si tienen todas las gemas
                        if (GemaRec == diamante)
                        {
                            Tablero2 TabNext = new Tablero2();
                            M.Jug.Punteo(50);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            TabNext.vida = vida;
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
                        if (DtgvTab[y - 1, x].Value != M.Portal)
                        {
                            DtgvTab[y - 1, x].Value = Vacio;
                        }
                    }


                }
            }
            //Validar si la tecla es S o flecha abajo
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                //Valida si esta en el rango
                if (x < (fila - 1))
                {
                    x = x + 1;
                    M.Celda[x - 1, y].Lleno = false;
                    //Valida si hay un diamante
                    if (DtgvTab[y, x].Value == M.Diamante)
                    {
                        GemaRec++;
                        M.Jug.Punteo(15);
                        puntaje = M.Jug.puntaje;
                        labelPuntaje.Text = Convert.ToString(puntaje);
                    }
                    //Valida si hay un portal
                    else if (DtgvTab[y, x].Value == M.Portal)
                    {
                        //Valida si tiene todas las gemas
                        if (GemaRec == diamante)
                        {
                            Tablero2 TabNext = new Tablero2();
                            M.Jug.Punteo(50);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                            TabNext.vida = vida;
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
                    //Valida si se debe cerrar el form
                    if (pass == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        DtgvTab[y, x - 1].Value = Vacio;
                        if (DtgvTab[y, x - 1].Value != M.Portal)
                        {
                            DtgvTab[y, x].Value = AvatarP;
                        }
                    }
                }
            }

            //Validar si es Q
            //Super Izquierda
            if (e.KeyCode== Keys.Q)
            {
                int mov = 0;
                //Validar Rango
                if (y > 1)
                {
                    //ciclo para repetir mov a la izquierda
                    do
                    {
                        y = y - 1;
                        M.Celda[x, y + 1].Lleno = false;
                        //Valida si hay un diamante
                        if (DtgvTab[y, x].Value == M.Diamante)
                        {
                            GemaRec++;
                            M.Jug.Punteo(15);
                            puntaje = M.Jug.puntaje;
                            labelPuntaje.Text = Convert.ToString(puntaje);
                        }
                        //Validar si hay un portal
                        else if (DtgvTab[y, x].Value == M.Portal)
                        {
                            //Valida si tiene todas las gemas
                            if (GemaRec == diamante)
                            {
                                Tablero2 TabNext = new Tablero2();
                                M.Jug.Punteo(50);
                                puntaje = M.Jug.puntaje;
                                labelPuntaje.Text = Convert.ToString(puntaje);
                                TabNext.vida = vida;
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
                            if (DtgvTab[y + 1, x].Value != M.Portal)
                            {
                                DtgvTab[y + 1, x].Value = Vacio;
                            }
                            mov++;
                        }

                    } while (mov < 2 & pass==false);
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
                        //Valida si hay un portal
                        else if (DtgvTab[y, x].Value == M.Portal)
                            {
                                //Valida si tienen todas las gemas
                                if (GemaRec == diamante)
                                {
                                    Tablero2 TabNext = new Tablero2();
                                    M.Jug.Punteo(50);
                                    puntaje = M.Jug.puntaje;
                                    labelPuntaje.Text = Convert.ToString(puntaje);
                                    TabNext.vida = vida;
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
                                if (DtgvTab[y - 1, x].Value != M.Portal)
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
                    if(MsM==0)
                    {
                        MessageBox.Show("Puede Avanzar al portal", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        MsM++;
                    }
                }

            }
            //Muestra la Ubicacion
            if(pass==false)
            {
                labelUbi.Text = "(" + x + "," + y + ")";
            }
        }
        //Finaliza el evento datagrid keyup
      

        //Inicializa las variables, funciones y metodos cuando carga el form
        private void Tablero1_Load(object sender, EventArgs e)
        {
            //Inicia tiempo
            if(puntaje!=0)
            {
                timer1.Start();
            }
            Vacio=M.Vacio;
            MsM=0;
            btnImprimirTab.Focus();
            M.Jug.Imagen(SelecAvatar);
            AvatarP = M.Jug.Jugador;
            M.Jug.Vidas(vida);
            M.Jug.Punteo(puntaje);
            labelname.Text = nombre;
            //Termina la partida al llegar a cero vidas
            if (vida==0)
            {
                timer1.Stop();
                MessageBox.Show("Ha perdido, lo sentimos","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Resultado Res = new Resultado();
                Res.puntaje = puntaje;
                Res.SelecAvatar = SelecAvatar;
                Res.nombre = nombre;
                Res.time = segundos;
                Res.Show();
                this.Close();
            }
        }
        //Finaliza Carga del form

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
            }
        }
        //Finaliza Formato datagrid

        //Boton Imprimir Tablero
        private void btnImprimirTab_Click(object sender, EventArgs e)
        {
            if (puntaje==0&vida==3)
            {
                timer1.Start();
            }
            DtgvTab.Focus();
            btnImprimirTab.Visible = false;
            DtgvTab.Rows.Add(fila);
            labelvida.Text = Convert.ToString(vida);
            labelPuntaje.Text = Convert.ToString(puntaje);
            //Asigna la altura a las filas
            for (int a=0; a<fila; a++)
            {
                DtgvTab.Rows[a].Height = 490 / fila;
            }

            //Imprime el tablero
            M.Dimensiones(fila, columna);
            M.LlenarCeldasBlanco();
            //Asigna las posiciones de los elementos
            M.Celda[2, 0].Imagen = AvatarP;
            M.Celda[2, 0].Lleno= true;
            M.Celda[0, 2].Imagen = M.Portal;
            M.Celda[0, 2].Lleno = true;
            M.Celda[1, 1].Imagen = M.Diamante;
            M.Celda[1, 1].Lleno = true;
            M.Celda[0, 1].Imagen = M.Diamante;
            M.Celda[0, 1].Lleno = true;
            M.Celda[1, 0].Imagen = M.Diamante;
            M.Celda[1, 0].Lleno = true;
            M.Celda[2, 3].Imagen = M.Diamante;
            M.Celda[2, 3].Lleno = true;
            //Busca las coordenas del avatar
            for (int i = 0; i < columna; i++)
            {
                for (int j =0; j <fila; j++)
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
    }
}
