namespace ProyectoCrystal_AndresVeliz
{
    partial class Preguntas
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
            this.LabelPregun = new System.Windows.Forms.Label();
            this.btnRes1 = new System.Windows.Forms.Button();
            this.btnRes2 = new System.Windows.Forms.Button();
            this.btnRes3 = new System.Windows.Forms.Button();
            this.btnRes4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPregun
            // 
            this.LabelPregun.AutoSize = true;
            this.LabelPregun.BackColor = System.Drawing.Color.Transparent;
            this.LabelPregun.Font = new System.Drawing.Font("Rockwell Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPregun.Location = new System.Drawing.Point(149, 101);
            this.LabelPregun.Name = "LabelPregun";
            this.LabelPregun.Size = new System.Drawing.Size(0, 24);
            this.LabelPregun.TabIndex = 1;
            // 
            // btnRes1
            // 
            this.btnRes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes1.Location = new System.Drawing.Point(35, 222);
            this.btnRes1.Name = "btnRes1";
            this.btnRes1.Size = new System.Drawing.Size(300, 50);
            this.btnRes1.TabIndex = 2;
            this.btnRes1.UseVisualStyleBackColor = true;
            this.btnRes1.Click += new System.EventHandler(this.btnRes1_Click);
            // 
            // btnRes2
            // 
            this.btnRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes2.Location = new System.Drawing.Point(35, 281);
            this.btnRes2.Name = "btnRes2";
            this.btnRes2.Size = new System.Drawing.Size(300, 50);
            this.btnRes2.TabIndex = 3;
            this.btnRes2.UseVisualStyleBackColor = true;
            this.btnRes2.Click += new System.EventHandler(this.btnRes2_Click);
            // 
            // btnRes3
            // 
            this.btnRes3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes3.Location = new System.Drawing.Point(390, 222);
            this.btnRes3.Name = "btnRes3";
            this.btnRes3.Size = new System.Drawing.Size(300, 50);
            this.btnRes3.TabIndex = 4;
            this.btnRes3.UseVisualStyleBackColor = true;
            this.btnRes3.Click += new System.EventHandler(this.btnRes3_Click);
            // 
            // btnRes4
            // 
            this.btnRes4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes4.Location = new System.Drawing.Point(390, 281);
            this.btnRes4.Name = "btnRes4";
            this.btnRes4.Size = new System.Drawing.Size(300, 50);
            this.btnRes4.TabIndex = 5;
            this.btnRes4.UseVisualStyleBackColor = true;
            this.btnRes4.Click += new System.EventHandler(this.btnRes4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoCrystal_AndresVeliz.Properties.Resources.Troll;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 144);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCrystal_AndresVeliz.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 427);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRes4);
            this.Controls.Add(this.btnRes3);
            this.Controls.Add(this.btnRes2);
            this.Controls.Add(this.btnRes1);
            this.Controls.Add(this.LabelPregun);
            this.DoubleBuffered = true;
            this.Name = "Preguntas";
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.Preguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPregun;
        private System.Windows.Forms.Button btnRes1;
        private System.Windows.Forms.Button btnRes2;
        private System.Windows.Forms.Button btnRes3;
        private System.Windows.Forms.Button btnRes4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}