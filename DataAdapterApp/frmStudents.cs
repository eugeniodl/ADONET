using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterApp
{
    public partial class frmStudents : Form
    {
        private readonly IStudentsRepository _studentsRepository;
        private DataSet dataSet;

        public frmStudents()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _studentsRepository = new StudentsRepository(connectionString);
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            try
            {
                dataSet = _studentsRepository.GetStudentsDataSet();
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "Students";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _studentsRepository.UpdateStudentsDataSet(dataSet);
                MessageBox.Show("Update successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating students: {ex.Message}");
            }
        }
    }
}
