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
    public partial class FormPuestos : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<Puesto> _repository;
        private readonly UnitOfWork _unitOfWork;
        public FormPuestos()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<Puesto>(_context);
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Puesto puesto = new Puesto();
            puesto.Nombre = textBox1.Text;
            puesto.NivelRiesgo = comboBox1.SelectedItem.ToString();
            puesto.SalarioMinimo = long.Parse(textBox2.Text);
            puesto.SalarioMaximo = long.Parse(textBox3.Text);
            puesto.Status = checkBox1.Checked ? 1 : 0;

            _repository.Add(puesto);
            _unitOfWork.Commit();

            updateDataGrid();

        }

        private void updateDataGrid()
        {
            var languageList = _repository.GetAll();
            dataGridView1.DataSource = languageList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Puesto puesto = new Puesto();
           
            puesto = _repository.FindById(long.Parse(textBox4.Text));
            if (puesto != null)
            {
                puesto.Nombre = textBox1.Text;
                puesto.NivelRiesgo = comboBox1.SelectedItem.ToString();
                puesto.SalarioMinimo = long.Parse(textBox2.Text);
                puesto.SalarioMaximo = long.Parse(textBox3.Text);
                puesto.Status = checkBox1.Checked ? 1 : 0;

                _repository.Update(puesto);
                _unitOfWork.Commit();
                updateDataGrid();
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Puesto puesto = new Puesto();

            puesto = _repository.FindById(long.Parse(textBox4.Text));
            if (puesto != null)
            {
                _repository.Remove(puesto);
                _unitOfWork.Commit();
                updateDataGrid();
            };
        }

        private void FormPuestos_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }

    
    }
}
