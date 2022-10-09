using Proyecto_recursos_humanos.Views;

namespace Proyecto_recursos_humanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loadForm(Object Form)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(f);
            this.panelContenido.Tag = f;
            f.Show();
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            loadForm(new FormCompetencias());
        }

        private void btnIdiomas_Click(object sender, EventArgs e)
        {
            loadForm(new FormIdiomas());
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            loadForm(new FormCapacitaciones());
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            loadForm(new FormPuestos());
        }

        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            loadForm(new FormCandidatos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new FormExperienciaLaboral());
        }
    }
}