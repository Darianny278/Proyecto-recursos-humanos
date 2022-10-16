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
    public partial class FormCompetencias : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<Competencia> _repository;
        private readonly UnitOfWork _unitOfWork;
        public FormCompetencias()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<Competencia>(_context);
            InitializeComponent();
        }

        private void FormCompetencias_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Competencia comp = new Competencia();
            comp.Description = textBox1.Text;
            comp.Status = checkBox1.Checked ? 1 : 0;

            _repository.Add(comp);
            _unitOfWork.Commit();

            updateDataGrid();
        }

        private void updateDataGrid()
        {
            var languageList = _repository.GetAll();
            dataGridView1.DataSource = languageList;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Competencia comp = new Competencia();

            comp = _repository.FindById(long.Parse(textBox2.Text));
            if (comp != null)
            {
                comp.Description = textBox1.Text;
                comp.Status = checkBox1.Checked ? 1 : 0;

                _repository.Update(comp);
                _unitOfWork.Commit();
                updateDataGrid();
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Competencia comp = new Competencia();

            comp = _repository.FindById(long.Parse(textBox2.Text));
            if (comp != null)
            {
                _repository.Remove(comp);
                _unitOfWork.Commit();
                updateDataGrid();
            };

        }
    }
}
