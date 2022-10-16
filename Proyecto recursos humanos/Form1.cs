using Proyecto_recursos_humanos.Entities;
using Proyecto_recursos_humanos.Repository;
using Proyecto_recursos_humanos.Views;

namespace Proyecto_recursos_humanos
{
    public partial class Form1 : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<Usuario> _repository;
        private readonly UnitOfWork _unitOfWork;

        public Form1()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<Usuario>(_context);
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user = _repository.GetAllByFilter((usuario) => usuario.Logged == true).FirstOrDefault();
            if (user != null)
            {

                user.Nombre = user.Nombre;
                user.Correo = user.Correo;
                user.Password = user.Password;
                user.Admin = user.Admin;
                user.Logged = false;
                _repository.Update(user);
                _unitOfWork.Commit();
                Application.Exit();
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

            var user = _repository.GetAllByFilter((usuario) => usuario.Logged == true).FirstOrDefault();
            if (user != null)
            {
                if (user.Correo != "admin@gmail.com")
                {
                    btnIdiomas.Hide();
                    btnCompetencias.Hide();
                    btnPuestos.Hide();
                    button3.Hide();
                }

                else
                {
                    button1.Hide();
                    btnCapacitaciones.Hide();
                }
            }
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user = _repository.GetAllByFilter((usuario) => usuario.Logged == true).FirstOrDefault();
            if (user != null)
            {

                user.Nombre = user.Nombre;
                user.Correo = user.Correo;
                user.Password = user.Password;
                user.Admin = user.Admin;
                user.Logged = false;
                _repository.Update(user);
                _unitOfWork.Commit();

                this.Hide();
                FormLogin fl = new FormLogin();
                fl.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new FormEmpleado());
        }
    }
}