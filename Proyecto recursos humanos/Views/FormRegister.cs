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

namespace Proyecto_recursos_humanos.Views
{
    public partial class FormRegister : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<Usuario> _repository;
        private readonly UnitOfWork _unitOfWork;
        public FormRegister()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<Usuario>(_context);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Correo = textBox1.Text;
            user.Nombre = textBox2.Text;
            user.Password = textBox3.Text;
            user.Admin = false;
            user.Logged = false;

            try
            {
                _repository.Add(user);
                _unitOfWork.Commit();

                label5.Text = "Usuario registrado correctamente";

            } catch(Exception exception)
            {
               
            };
        }
    }
}
