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
    public partial class FormCapacitaciones : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<Capacitacione> _repository;
        private readonly IBaseRepository<Usuario> _repositoryUser;
        private readonly UnitOfWork _unitOfWork;

        public FormCapacitaciones()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<Capacitacione>(_context);
            _repositoryUser = new BaseRepository<Usuario>(_context);
            InitializeComponent();
        }

        private void FormCapacitaciones_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Capacitacione cap = new Capacitacione();
            var user = _repositoryUser.GetAllByFilter((user) => user.Logged == true).FirstOrDefault();

            cap.Description = textBox1.Text;
            cap.Nivel = comboBox1.SelectedItem.ToString();
            cap.FechaInicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            cap.FechaFin = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            cap.Institucion = textBox2.Text;
            cap.UsuarioId = user.Id;

            _repository.Add(cap);
            _unitOfWork.Commit();

            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
           dataGridView1.DataSource = _repository.GetAll();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Capacitacione cap = new Capacitacione();
            cap = _repository.FindById(int.Parse(textBox3.Text));
            var user = _repositoryUser.GetAllByFilter((user) => user.Logged == true).FirstOrDefault();

            if (cap != null)
            {
                cap.Description = textBox1.Text;
                cap.Nivel = comboBox1.SelectedItem.ToString();
                cap.FechaInicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cap.FechaFin = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                cap.Institucion = textBox2.Text;
                cap.UsuarioId = user.Id;

                _repository.Update(cap);
                _unitOfWork.Commit();

                UpdateDataGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Capacitacione cap = new Capacitacione();
            cap = _repository.FindById(int.Parse(textBox3.Text));

            if (cap != null)
            {

                _repository.Remove(cap);
                _unitOfWork.Commit();

                UpdateDataGrid();
            }
        }
    }
}
