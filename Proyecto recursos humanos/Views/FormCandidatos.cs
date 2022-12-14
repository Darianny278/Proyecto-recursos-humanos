using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Proyecto_recursos_humanos.Views
{
    public partial class FormCandidatos : Form
    {
        private readonly DBProyectoFinalContext _context;
        private readonly IBaseRepository<Candidato> _repository;
        private readonly IBaseRepository<Usuario> _repositoryUser;
        private readonly IBaseRepository<Idioma> _repositoryIdioma;
        private readonly IBaseRepository<Competencia> _repositoryCompetencia;
        private readonly IBaseRepository<Puesto> _repositoryPuesto;
        private readonly IBaseRepository<ExperienciasLaborale> _repositoryExp;
        private readonly IBaseRepository<UsuarioIdioma> _repositoryUI;
        private readonly IBaseRepository<UsuarioCompetencium> _repositoryUC;
        private readonly IBaseRepository<Empleado> _repositoryEmpleado;
        private readonly IBaseRepository<Capacitacione> _repositoryCapacitacion;
        private readonly UnitOfWork _unitOfWork;
        public FormCandidatos()
        {
            _context = new DBProyectoFinalContext();
            _unitOfWork = new UnitOfWork(_context);
            _repository = new BaseRepository<Candidato>(_context);
            _repositoryUser = new BaseRepository<Usuario>(_context);
            _repositoryIdioma = new BaseRepository<Idioma>(_context);
            _repositoryCompetencia = new BaseRepository<Competencia>(_context);
            _repositoryPuesto = new BaseRepository<Puesto>(_context);
            _repositoryExp = new BaseRepository<ExperienciasLaborale>(_context);
            _repositoryUI = new BaseRepository<UsuarioIdioma>(_context);
            _repositoryUC = new BaseRepository<UsuarioCompetencium>(_context);
            _repositoryEmpleado = new BaseRepository<Empleado>(_context);
            _repositoryCapacitacion = new BaseRepository<Capacitacione>(_context);
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormCandidatos_Load(object sender, EventArgs e)
        {
            var idiomas = _repositoryIdioma.GetAll();
            var itemIdiomas = checkedListBox2.Items;

            foreach(var idioma in idiomas)
            {
               itemIdiomas.Add(idioma.Name);
            }

            var competencias = _repositoryCompetencia .GetAll();
            var itemCompetencias = checkedListBox1.Items;
            foreach (var comp in competencias)
            {
                itemCompetencias.Add(comp.Description);
            }

            var puestos = _repositoryPuesto.GetAll();
            var itemPuestos = comboBox1.Items;
            foreach (var puesto in puestos)
            {
                itemPuestos.Add(puesto.Nombre);
            }

            var user = _repositoryUser.GetAllByFilter((user) => user.Logged == true).FirstOrDefault();
            if(user != null)
            {
                textBox1.Text = user.Nombre;
            }

            if(user.Correo != "admin@gmail.com")
            {
                dataGridView1.Hide();
                button4.Hide();
                comboBox2.Hide();
                comboBox3.Hide();
                textBox2.Hide();
                button5.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                dataGridView2.Hide();
                dataGridView3.Hide();
                dataGridView4.Hide();
                dataGridView5.Hide();
            } else
            {
                dataGridView1.DataSource = _repository.GetAll();

            }
        }

     

        private void addOrRemoveIdiomaAndCompetencias()
        {
        
            var user = _repositoryUser.GetAllByFilter((user) => user.Logged == true).FirstOrDefault();

            foreach (Object item in checkedListBox2.CheckedItems)
            {
            
                var idioma = _repositoryIdioma.GetAllByFilter((idi) => idi.Name == item.ToString()).FirstOrDefault();
                UsuarioIdioma us = new UsuarioIdioma();
                us = _repositoryUI.GetAllByFilter((ui) => ui.UsuarioId == user.Id && ui.IdiomaId == idioma.Id).FirstOrDefault();

                if (us == null)
                {
                    UsuarioIdioma usu = new UsuarioIdioma();
                    usu.UsuarioId = user.Id;
                    usu.IdiomaId = idioma.Id;
                    _repositoryUI.Add(usu);
                    _unitOfWork.Commit();
                }
                
            }

            foreach (object item in checkedListBox2.Items)
            {
                if (!checkedListBox2.CheckedItems.Contains(item))
                {
                    var idioma = _repositoryIdioma.GetAllByFilter((idi) => idi.Name == item.ToString()).FirstOrDefault();
                  
                    UsuarioIdioma us = new UsuarioIdioma();
                    us = _repositoryUI.GetAllByFilter((ui) => ui.UsuarioId == user.Id && ui.IdiomaId == idioma.Id).FirstOrDefault();

                    if (us != null)
                    {
                        _repositoryUI.Remove(us);
                        _unitOfWork.Commit();
                    }

                }
            }


            foreach (Object item in checkedListBox1.CheckedItems)
            {

                var comp = _repositoryCompetencia.GetAllByFilter((idi) => idi.Description == item.ToString()).FirstOrDefault();
                UsuarioCompetencium us = new UsuarioCompetencium();
                us = _repositoryUC.GetAllByFilter((ui) => ui.UsuarioId == user.Id && ui.CompetenciaId == comp.Id).FirstOrDefault();

                if (us == null)
                {
                    UsuarioCompetencium usu = new UsuarioCompetencium();
                    usu.UsuarioId = user.Id;
                    usu.CompetenciaId = comp.Id;

                    _repositoryUC.Add(usu);
                    _unitOfWork.Commit();
                }

            }

            foreach (object item in checkedListBox1.Items)
            {
                if (!checkedListBox1.CheckedItems.Contains(item))
                {
                    var competencia = _repositoryCompetencia.GetAllByFilter((idi) => idi.Description == item.ToString()).FirstOrDefault();

                    UsuarioCompetencium us = new UsuarioCompetencium();
                    us = _repositoryUC.GetAllByFilter((ui) => ui.UsuarioId == user.Id && ui.CompetenciaId == competencia.Id).FirstOrDefault();

                    if (us != null)
                    {
                        _repositoryUC.Remove(us);
                        _unitOfWork.Commit();
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Candidato cap = new Candidato();
            var user = _repositoryUser.GetAllByFilter((user) => user.Logged == true).FirstOrDefault();
            var puesto = _repositoryPuesto.GetAllByFilter((pu) => pu.Nombre == comboBox1.SelectedItem.ToString()).FirstOrDefault();
            cap.Cedula = long.Parse(textBox4.Text);
            cap.UsuarioId = user.Id;
            cap.PuestoId = puesto.Id;
            cap.Departamento = textBox5.Text;
            cap.Salario = long.Parse(textBox3.Text);
            cap.RecomendadoPor = textBox6.Text;
            cap.Reclutado = false;

            var solicitud = _repository.GetAllByFilter((so) => so.UsuarioId == user.Id && so.Cedula == long.Parse(textBox4.Text)).FirstOrDefault();
            if (solicitud == null)
            {
                _repository.Add(cap);
                _unitOfWork.Commit();
                addOrRemoveIdiomaAndCompetencias();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var user = _repositoryUser.GetAllByFilter((user) => user.Nombre == textBox1.Text).FirstOrDefault();
            var cap = _repository.GetAllByFilter((so) => so.UsuarioId == user.Id).FirstOrDefault();
            var puesto = _repositoryPuesto.GetAllByFilter((pu) => pu.Nombre == comboBox1.SelectedItem.ToString()).FirstOrDefault();
            cap.Cedula = long.Parse(textBox4.Text);
            cap.UsuarioId = user.Id;
            cap.PuestoId = puesto.Id;
            cap.Departamento = textBox5.Text;
            cap.Salario = long.Parse(textBox3.Text);
            cap.RecomendadoPor = textBox6.Text;
            cap.Reclutado = false;

            if (cap != null)
            {
                _repository.Update(cap);
                _unitOfWork.Commit();
                addOrRemoveIdiomaAndCompetencias();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var user = _repositoryUser.GetAllByFilter((user) => user.Logged == true).FirstOrDefault();
            var cap = _repository.GetAllByFilter((so) => so.UsuarioId == user.Id).FirstOrDefault();
           

            if (cap != null)
            {
                _repository.Remove(cap);
                _unitOfWork.Commit();
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cap = _repository.GetAllByFilter((so) => so.Id == long.Parse(textBox2.Text)).FirstOrDefault();
            var user = _repositoryUser.GetAllByFilter((user) => user.Id == cap.UsuarioId).FirstOrDefault();
            var puesto = _repositoryPuesto.GetAllByFilter((pu) => pu.Id == cap.PuestoId).FirstOrDefault();

            DateTime dt = DateTime.Now;
            string sDate = dt.ToShortDateString();

            Empleado emp = new Empleado();
            emp.Nombre = user.Nombre;
            emp.Cedula = cap.Cedula;
            emp.Puesto = puesto.Nombre;
            emp.Salario = cap.Salario;
            emp.Departamento = cap.Departamento;
            emp.FechaInicio = sDate;
            emp.Status = true;

            if (cap.Reclutado != true)
            {
                _repositoryEmpleado.Add(emp);
                _unitOfWork.Commit();

                updateStatus();
            }

        }
        
        public void updateStatus()
        {
            var cap = _repository.GetAllByFilter((so) => so.Id == long.Parse(textBox2.Text)).FirstOrDefault();
            cap.Cedula = cap.Cedula;
            cap.UsuarioId = cap.UsuarioId;
            cap.PuestoId = cap.PuestoId;
            cap.Departamento = cap.Departamento;
            cap.Salario = cap.Salario;
            cap.RecomendadoPor = cap.RecomendadoPor;
            cap.Reclutado = true;

            if (cap != null)
            {
                _repository.Update(cap);
                _unitOfWork.Commit();
             
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var can = _repository.GetAllByFilter((can) => can.Id == long.Parse(textBox2.Text)).FirstOrDefault();

            dataGridView2.DataSource = _repositoryUI.GetAllByFilter((idioma) => idioma.UsuarioId == can.UsuarioId);
            dataGridView3.DataSource = _repositoryCapacitacion.GetAllByFilter((cap) => cap.UsuarioId == can.UsuarioId);
            dataGridView4.DataSource = _repositoryUC.GetAllByFilter((cap) => cap.UsuarioId == can.UsuarioId);
            dataGridView5.DataSource = _repositoryExp.GetAllByFilter((cap) => cap.UsuarioId == can.UsuarioId);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem.ToString() == "idiomas")
            {
                var idiomas = _repositoryIdioma.GetAll();
                comboBox3.Items.Clear();
                foreach (var item in idiomas)
                {
                    comboBox3.Items.Add(item.Name);
                }
            }
            if(comboBox2.SelectedItem.ToString() == "puestos")
            {
                var puestos = _repositoryPuesto.GetAll();
                comboBox3.Items.Clear();
                foreach (var item in puestos)
                {
                    comboBox3.Items.Add(item.Nombre);
                }
            }
            if (comboBox2.SelectedItem.ToString() == "competencias")
            {
                var competencias = _repositoryCompetencia.GetAll();
                comboBox3.Items.Clear();
                foreach (var item in competencias)
                {
                    comboBox3.Items.Add(item.Description);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox txt))
                return;

            // Filter out any invalid chars that are typed/pasted and leave the cursor where it was (or reasonably close).
            int pos = txt.SelectionStart;
            txt.Text = string.Concat(txt.Text.Where(c => "0123456789".IndexOf(c) != -1));
            txt.SelectionStart = pos;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "idiomas")
            {
                var idioma = _repositoryIdioma.GetAllByFilter((idom) => idom.Name == comboBox3.SelectedItem.ToString()).FirstOrDefault();
                var users = _repositoryUI.GetAllByFilter((idi) => idi.IdiomaId == idioma.Id);
                var list = new List<Candidato>();
                foreach (var user in users)
                {
                    var candidato = _repository.GetAllByFilter((cand) => cand.UsuarioId == user.Id).FirstOrDefault();
                    list.Add(candidato);
   
                }

                dataGridView1.DataSource = list;
            }
            if (comboBox2.SelectedItem.ToString() == "puestos")
            {
                var puesto = _repositoryPuesto.GetAllByFilter((idom) => idom.Nombre == comboBox3.SelectedItem.ToString()).FirstOrDefault();

                dataGridView1.DataSource = _repository.GetAllByFilter((can) => can.PuestoId == puesto.Id);
            }
            if (comboBox2.SelectedItem.ToString() == "competencias")
            {
                var competencia = _repositoryCompetencia.GetAllByFilter((idom) => idom.Description == comboBox3.SelectedItem.ToString()).FirstOrDefault();
                var users = _repositoryUC.GetAllByFilter((idi) => idi.CompetenciaId == competencia.Id);
                var list = new List<Candidato>();
                foreach (var user in users)
                {
                    var candidato = _repository.GetAllByFilter((cand) => cand.UsuarioId == user.Id).FirstOrDefault();
                    list.Add(candidato);

                }

                dataGridView1.DataSource = list;
            }
        }
    }
}
