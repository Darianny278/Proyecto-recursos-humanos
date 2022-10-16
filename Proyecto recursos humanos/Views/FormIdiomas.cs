using Proyecto_recursos_humanos.Entities;
using Proyecto_recursos_humanos.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_recursos_humanos.Views
{
    public partial class FormIdiomas : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<Idioma> _repository;
        private readonly UnitOfWork _unitOfWork;
        public FormIdiomas()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<Idioma>(_context);
            InitializeComponent();
        }

        private void FormIdiomas_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            Idioma idioma = new Idioma();
            idioma.Name = textBox1.Text;
            idioma.Status = checkBox1.Checked ? 1 : 0;

            _repository.Add(idioma);
            _unitOfWork.Commit();

            updateDataGrid();

        }

        private void updateDataGrid()
        {
            var languageList = _repository.GetAll();
            dataGridView1.DataSource = languageList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();

            idioma = _repository.FindById(long.Parse(textBox2.Text));
            if(idioma != null)
            {

                idioma.Name = textBox1.Text;
                idioma.Status = checkBox1.Checked ? 1 : 0;

                _repository.Update(idioma);
                _unitOfWork.Commit();
                updateDataGrid();
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();

            var language = _repository.FindById(long.Parse(textBox2.Text));
            if (language != null)
            {
                _repository.Remove(language);
                _unitOfWork.Commit();
                updateDataGrid();
            };
        }
    }
}
