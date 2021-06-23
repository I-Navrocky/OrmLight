using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OrmLight.Adapters
{
    class MySqlAdapter : BaseAdapter
    {
        private string _connString;
        private MySqlConnection _connection;
        private bool _needConnect;

        public MySqlAdapter(string connStr)
        {
            AdapterType = AdapterType.MySql;
            _connString = connStr;            
            _needConnect = true;
        }

        private void Connect()
        {
            try
            {
                if (_connection != null)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
                
                _connection = new MySqlConnection(_connString);
                _connection.Open();
                _needConnect = false;

                if (_connection.State != System.Data.ConnectionState.Open)               
                    throw new ApplicationException("Connection attempt failed");
            }
            catch (Exception ex)
            {
                //TODO: обрбаботать или убрать
                _needConnect = true;
            }
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                var sqlCommand = new MySqlCommand(query, _connection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //TODO: обрбаботать или убрать   
            }
        }


    }
}
