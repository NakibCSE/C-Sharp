using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExample
{
    public class AdoNetUtility
    {
        private readonly string __connectionString;
        public AdoNetUtility(string connectionString)
        {
            __connectionString = connectionString;
        }
    
        public void RunSql(string sql, Dictionary<string, object> parameters)
        {
            using SqlConnection sqlConnection = new SqlConnection(__connectionString);
            using SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
            }

            if(sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            int rowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Dispose();
            sqlCommand.Dispose(); 
        }
        public List<Dictionary<string, object>> GetData(string sql, Dictionary<string, object>parameters)
        {
            using SqlConnection sqlConnection = new SqlConnection(__connectionString);
            using SqlCommand sqlCommand = new SqlCommand( sql, sqlConnection);

            foreach(var parameter in parameters)
            {
                sqlCommand.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
            }
            if(sqlConnection.State != System.Data.ConnectionState.Open)
            { sqlConnection.Open(); }

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for(int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    string columnName = sqlDataReader.GetName(i);
                    object value = sqlDataReader.GetValue(i);

                    row.Add(columnName, value);
                }
                result.Add(row);
            }
            return result;
        }
    }
}
