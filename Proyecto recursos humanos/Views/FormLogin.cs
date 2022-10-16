using Proyecto_recursos_humanos.Entities;
using Proyecto_recursos_humanos.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_recursos_humanos.Views
{
    public partial class FormLogin : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<Usuario> _repository;
        private readonly UnitOfWork _unitOfWork;
        public FormLogin()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<Usuario>(_context);
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            var userAdmin = _repository.GetAllByFilter((usuario) => usuario.Correo == "admin@gmail.com").FirstOrDefault();
            if (userAdmin == null)
            {
                Usuario user = new Usuario();

                user.Nombre = "Admin";
                user.Correo = "admin@gmail.com";
                user.Password = "admin1234";
                user.Admin = true;
                user.Logged = false;
                _repository.Add(user);
                _unitOfWork.Commit();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            this.Hide();
            formRegister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user = _repository.GetAllByFilter((usuario) => usuario.Correo == textBox1.Text).FirstOrDefault();
            if (user != null)
            {
                if (user.Correo == textBox1.Text && user.Password == textBox2.Text)
                {
                    user.Nombre = user.Nombre;
                    user.Correo = user.Correo;
                    user.Password = user.Password;
                    user.Admin = false;
                    user.Logged = true;
                    _repository.Update(user);
                    _unitOfWork.Commit();

                    Form1 welcome = new Form1();
                    this.Hide();
                    welcome.Show();


                }
            };
        }
    }
}
