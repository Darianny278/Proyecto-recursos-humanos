namespace Proyecto_recursos_humanos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barraTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCandidatos = new System.Windows.Forms.Button();
            this.btnPuestos = new System.Windows.Forms.Button();
            this.btnCapacitaciones = new System.Windows.Forms.Button();
            this.btnIdiomas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCompetencias = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.barraTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTop
            // 
            this.barraTop.BackColor = System.Drawing.Color.Navy;
            this.barraTop.Controls.Add(this.btnCerrar);
            this.barraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTop.Location = new System.Drawing.Point(0, 0);
            this.barraTop.Name = "barraTop";
            this.barraTop.Size = new System.Drawing.Size(858, 31);
            this.barraTop.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(825, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.White;
            this.sideBar.Controls.Add(this.button1);
            this.sideBar.Controls.Add(this.btnCandidatos);
            this.sideBar.Controls.Add(this.btnPuestos);
            this.sideBar.Controls.Add(this.btnCapacitaciones);
            this.sideBar.Controls.Add(this.btnIdiomas);
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.btnCompetencias);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 31);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(198, 479);
            this.sideBar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(0, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Experiencia laboral";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCandidatos
            // 
            this.btnCandidatos.BackColor = System.Drawing.Color.White;
            this.btnCandidatos.FlatAppearance.BorderSize = 0;
            this.btnCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidatos.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCandidatos.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCandidatos.Location = new System.Drawing.Point(0, 272);
            this.btnCandidatos.Name = "btnCandidatos";
            this.btnCandidatos.Size = new System.Drawing.Size(198, 41);
            this.btnCandidatos.TabIndex = 6;
            this.btnCandidatos.Text = "Candidatos";
            this.btnCandidatos.UseVisualStyleBackColor = false;
            this.btnCandidatos.Click += new System.EventHandler(this.btnCandidatos_Click);
            // 
            // btnPuestos
            // 
            this.btnPuestos.BackColor = System.Drawing.Color.White;
            this.btnPuestos.FlatAppearance.BorderSize = 0;
            this.btnPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuestos.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPuestos.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPuestos.Location = new System.Drawing.Point(0, 225);
            this.btnPuestos.Name = "btnPuestos";
            this.btnPuestos.Size = new System.Drawing.Size(198, 41);
            this.btnPuestos.TabIndex = 5;
            this.btnPuestos.Text = "Puestos";
            this.btnPuestos.UseVisualStyleBackColor = false;
            this.btnPuestos.Click += new System.EventHandler(this.btnPuestos_Click);
            // 
            // btnCapacitaciones
            // 
            this.btnCapacitaciones.BackColor = System.Drawing.Color.White;
            this.btnCapacitaciones.FlatAppearance.BorderSize = 0;
            this.btnCapacitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacitaciones.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapacitaciones.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCapacitaciones.Location = new System.Drawing.Point(0, 178);
            this.btnCapacitaciones.Name = "btnCapacitaciones";
            this.btnCapacitaciones.Size = new System.Drawing.Size(198, 41);
            this.btnCapacitaciones.TabIndex = 4;
            this.btnCapacitaciones.Text = "Capacitaciones";
            this.btnCapacitaciones.UseVisualStyleBackColor = false;
            this.btnCapacitaciones.Click += new System.EventHandler(this.btnCapacitaciones_Click);
            // 
            // btnIdiomas
            // 
            this.btnIdiomas.BackColor = System.Drawing.Color.White;
            this.btnIdiomas.FlatAppearance.BorderSize = 0;
            this.btnIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdiomas.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIdiomas.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnIdiomas.Location = new System.Drawing.Point(0, 131);
            this.btnIdiomas.Name = "btnIdiomas";
            this.btnIdiomas.Size = new System.Drawing.Size(198, 41);
            this.btnIdiomas.TabIndex = 3;
            this.btnIdiomas.Text = "Idiomas";
            this.btnIdiomas.UseVisualStyleBackColor = false;
            this.btnIdiomas.Click += new System.EventHandler(this.btnIdiomas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 78);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox2.Size = new System.Drawing.Size(170, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnCompetencias
            // 
            this.btnCompetencias.BackColor = System.Drawing.Color.White;
            this.btnCompetencias.FlatAppearance.BorderSize = 0;
            this.btnCompetencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetencias.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompetencias.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCompetencias.Location = new System.Drawing.Point(0, 84);
            this.btnCompetencias.Name = "btnCompetencias";
            this.btnCompetencias.Size = new System.Drawing.Size(198, 41);
            this.btnCompetencias.TabIndex = 1;
            this.btnCompetencias.Text = "Competencias";
            this.btnCompetencias.UseVisualStyleBackColor = false;
            this.btnCompetencias.Click += new System.EventHandler(this.btnCompetencias_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(198, 31);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(660, 479);
            this.panelContenido.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 510);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.barraTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.barraTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel barraTop;
        private Panel sideBar;
        private PictureBox btnCerrar;
        private Panel panelContenido;
        private Button btnCompetencias;
        private Button button1;
        private Button btnCandidatos;
        private Button btnPuestos;
        private Button btnCapacitaciones;
        private Button btnIdiomas;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}