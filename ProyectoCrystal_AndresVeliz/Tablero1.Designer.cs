namespace ProyectoCrystal_AndresVeliz
{
    partial class Tablero1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtgvTab = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.C2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.C3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.C4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImprimirTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelvida = new System.Windows.Forms.Label();
            this.labelPuntaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnComan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbgema3 = new System.Windows.Forms.PictureBox();
            this.pbgema4 = new System.Windows.Forms.PictureBox();
            this.pbgema2 = new System.Windows.Forms.PictureBox();
            this.pbgema1 = new System.Windows.Forms.PictureBox();
            this.Tiempo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUbi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvTab)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgema3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgema4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgema2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgema1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgvTab
            // 
            this.DtgvTab.AllowUserToAddRows = false;
            this.DtgvTab.AllowUserToDeleteRows = false;
            this.DtgvTab.AllowUserToResizeColumns = false;
            this.DtgvTab.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DtgvTab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgvTab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgvTab.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DtgvTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvTab.ColumnHeadersVisible = false;
            this.DtgvTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4});
            this.DtgvTab.GridColor = System.Drawing.SystemColors.Control;
            this.DtgvTab.Location = new System.Drawing.Point(253, 50);
            this.DtgvTab.Name = "DtgvTab";
            this.DtgvTab.ReadOnly = true;
            this.DtgvTab.RowHeadersVisible = false;
            this.DtgvTab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DtgvTab.Size = new System.Drawing.Size(742, 494);
            this.DtgvTab.TabIndex = 0;
            this.DtgvTab.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgvTab_CellFormatting);
            this.DtgvTab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtgvTab_KeyUp);
            // 
            // C1
            // 
            this.C1.HeaderText = "Column1";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            // 
            // C2
            // 
            this.C2.HeaderText = "Column1";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            // 
            // C3
            // 
            this.C3.HeaderText = "Column1";
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            // 
            // C4
            // 
            this.C4.HeaderText = "Column1";
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            // 
            // btnImprimirTab
            // 
            this.btnImprimirTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTab.Location = new System.Drawing.Point(12, 70);
            this.btnImprimirTab.Name = "btnImprimirTab";
            this.btnImprimirTab.Size = new System.Drawing.Size(134, 45);
            this.btnImprimirTab.TabIndex = 1;
            this.btnImprimirTab.Text = "Imprimir Tablero";
            this.btnImprimirTab.UseVisualStyleBackColor = true;
            this.btnImprimirTab.Click += new System.EventHandler(this.btnImprimirTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puntaje:";
            // 
            // labelvida
            // 
            this.labelvida.AutoSize = true;
            this.labelvida.BackColor = System.Drawing.Color.Transparent;
            this.labelvida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvida.Location = new System.Drawing.Point(50, 82);
            this.labelvida.Name = "labelvida";
            this.labelvida.Size = new System.Drawing.Size(0, 15);
            this.labelvida.TabIndex = 5;
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.AutoSize = true;
            this.labelPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.labelPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntaje.Location = new System.Drawing.Point(65, 111);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(0, 15);
            this.labelPuntaje.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jugador:";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(21, 55);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(0, 15);
            this.labelname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nivel 1";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(26, 541);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(134, 45);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "Terminar Partida";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnComan
            // 
            this.btnComan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComan.Location = new System.Drawing.Point(26, 481);
            this.btnComan.Name = "btnComan";
            this.btnComan.Size = new System.Drawing.Size(134, 45);
            this.btnComan.TabIndex = 11;
            this.btnComan.Text = "Comandos";
            this.btnComan.UseVisualStyleBackColor = true;
            this.btnComan.Click += new System.EventHandler(this.btnComan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbgema3);
            this.groupBox1.Controls.Add(this.pbgema4);
            this.groupBox1.Controls.Add(this.pbgema2);
            this.groupBox1.Controls.Add(this.pbgema1);
            this.groupBox1.Location = new System.Drawing.Point(36, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caja Recolectora";
            // 
            // pbgema3
            // 
            this.pbgema3.BackgroundImage = global::ProyectoCrystal_AndresVeliz.Properties.Resources.Gema;
            this.pbgema3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbgema3.Location = new System.Drawing.Point(10, 52);
            this.pbgema3.Name = "pbgema3";
            this.pbgema3.Size = new System.Drawing.Size(34, 27);
            this.pbgema3.TabIndex = 3;
            this.pbgema3.TabStop = false;
            this.pbgema3.Visible = false;
            // 
            // pbgema4
            // 
            this.pbgema4.BackgroundImage = global::ProyectoCrystal_AndresVeliz.Properties.Resources.Gema;
            this.pbgema4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbgema4.Location = new System.Drawing.Point(50, 52);
            this.pbgema4.Name = "pbgema4";
            this.pbgema4.Size = new System.Drawing.Size(34, 27);
            this.pbgema4.TabIndex = 2;
            this.pbgema4.TabStop = false;
            this.pbgema4.Visible = false;
            // 
            // pbgema2
            // 
            this.pbgema2.BackgroundImage = global::ProyectoCrystal_AndresVeliz.Properties.Resources.Gema;
            this.pbgema2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbgema2.Location = new System.Drawing.Point(50, 19);
            this.pbgema2.Name = "pbgema2";
            this.pbgema2.Size = new System.Drawing.Size(34, 27);
            this.pbgema2.TabIndex = 1;
            this.pbgema2.TabStop = false;
            this.pbgema2.Visible = false;
            // 
            // pbgema1
            // 
            this.pbgema1.BackgroundImage = global::ProyectoCrystal_AndresVeliz.Properties.Resources.Gema;
            this.pbgema1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbgema1.Location = new System.Drawing.Point(10, 19);
            this.pbgema1.Name = "pbgema1";
            this.pbgema1.Size = new System.Drawing.Size(34, 27);
            this.pbgema1.TabIndex = 0;
            this.pbgema1.TabStop = false;
            this.pbgema1.Visible = false;
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSize = true;
            this.Tiempo.BackColor = System.Drawing.Color.Transparent;
            this.Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo.Location = new System.Drawing.Point(81, 140);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(0, 15);
            this.Tiempo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tiempo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelUbi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Tiempo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelvida);
            this.groupBox2.Controls.Add(this.labelPuntaje);
            this.groupBox2.Controls.Add(this.labelname);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 197);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado del Avatar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ubicación:";
            // 
            // labelUbi
            // 
            this.labelUbi.AutoSize = true;
            this.labelUbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbi.Location = new System.Drawing.Point(71, 170);
            this.labelUbi.Name = "labelUbi";
            this.labelUbi.Size = new System.Drawing.Size(0, 13);
            this.labelUbi.TabIndex = 22;
            // 
            // Tablero1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCrystal_AndresVeliz.Properties.Resources.FondoVerdeClaro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 616);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnComan);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImprimirTab);
            this.Controls.Add(this.DtgvTab);
            this.Name = "Tablero1";
            this.Text = "Tablero1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tablero1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvTab)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbgema3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgema4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgema2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgema1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvTab;
        private System.Windows.Forms.Button btnImprimirTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelvida;
        private System.Windows.Forms.Label labelPuntaje;
        private System.Windows.Forms.DataGridViewImageColumn C1;
        private System.Windows.Forms.DataGridViewImageColumn C2;
        private System.Windows.Forms.DataGridViewImageColumn C3;
        private System.Windows.Forms.DataGridViewImageColumn C4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnComan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbgema3;
        private System.Windows.Forms.PictureBox pbgema4;
        private System.Windows.Forms.PictureBox pbgema2;
        private System.Windows.Forms.PictureBox pbgema1;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelUbi;
        private System.Windows.Forms.Label label6;
    }
}