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
    public partial class FormExperienciaLaboral : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<ExperienciasLaborale> _repository;
        private readonly IBaseRepository<Usuario> _repositoryUser;
        private readonly UnitOfWork _unitOfWork;
        public FormExperienciaLaboral()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<ExperienciasLaborale>(_context);
            _repositoryUser = new BaseRepository<Usuario>(_context);
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExperienciasLaborale exp = new ExperienciasLaborale();
            var user = _repositoryUser.GetAllByFilter((user) => user.Logged == true).FirstOrDefault();

            exp.Empresa = textBox1.Text;
            exp.Puesto = textBox2.Text;
            exp.Inicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            exp.Hasta = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            exp.Salario = textBox3.Text;
            exp.UsuarioId = user.Id;

            _repository.Add(exp);
            _unitOfWork.Commit();

            updateDataGrid();
        }

        private void updateDataGrid()
        {
            dataGridView1.DataSource = _repository.GetAll();
           
        }

        private void FormExperienciaLaboral_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var exp = _repository.FindById(int.Parse(textBox4.Text));
            var user = _repositoryUser.GetAllByFilter((user) => user.Logged == true).FirstOrDefault();

            if (exp != null)
            {
                exp.Empresa = textBox1.Text;
                exp.Puesto = textBox2.Text;
                exp.Inicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                exp.Hasta = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                exp.Salario = textBox3.Text;
                exp.UsuarioId = user.Id;

                _repository.Update(exp);
                _unitOfWork.Commit();

                updateDataGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var exp = _repository.FindById(int.Parse(textBox4.Text));
            if (exp != null)
            {
                _repository.Remove(exp);
                _unitOfWork.Commit();

                updateDataGrid();
            }
        }
    }
}
