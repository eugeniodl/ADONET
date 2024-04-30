using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterApp
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly string _connectionString;

        public StudentsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DataSet GetStudentsDataSet()
        {
            using(SqlConnection sqlConnection 
                = new SqlConnection(_connectionString))
            {
                string commandString = "SELECT * FROM Students";
                using(SqlCommand command 
                    = new SqlCommand(commandString, sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Students");
                    return dataSet;
                }
            }
        }

        public void UpdateStudentsDataSet(DataSet dataSet)
        {
            using(SqlConnection sqlConnection =
                new SqlConnection(_connectionString))
            {
                string commandString = "SELECT * FROM Students";
                using(SqlCommand command
                    = new SqlCommand(commandString, sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    SqlCommandBuilder sqlCommandBuilder =
                        new SqlCommandBuilder(adapter);
                    adapter.Update(dataSet, "Students");
                }
            }
        }
    }
}
