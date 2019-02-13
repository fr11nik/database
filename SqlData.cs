using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_лаба_номер_2
{
    class SqlData
    {
        private string connectionString= "Data Source=DESKTOP-FRUINIK;Database=LabaNumber3;Integrated Security = false;User ID=User;pwd=123";
        private string query= "SELECT * FROM Students ORDER BY [ID Студента]";
        
        SqlDataReader reader;
        SqlConnection myConnections;
        //  string connectionThrougTCP = "Data Source=tcp:192.168.0.14;Initial Catalog=LabaNumber3;User ID=User;pwd=123";
        public SqlData()
        {
            readDataSql();                      
            
        }
        public void readDataSql()
        {
         
            myConnections = new SqlConnection(connectionString);
            myConnections.Open();
           
            SqlCommand command = new SqlCommand(query, myConnections);               
            reader = command.ExecuteReader();        
            
        }
       
        public List<string[]> WriteSqlData(List<string[]> outputdata)
        {
            
                while (reader.Read())
                {
                    outputdata.Add(new string[7]);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        outputdata[outputdata.Count - 1][i] = reader[i].ToString();

                    }

                }      
            myConnections.Close();
            reader.Close(); 
            

            return outputdata;
                       
           
        }
        
    }
}
