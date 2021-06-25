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
            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
            }

            _connection = new MySqlConnection(_connString);
            _connection.Open();

            if (_connection.State != System.Data.ConnectionState.Open)
                throw new ApplicationException("Connection attempt failed");

            _needConnect = false;
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                if (_needConnect)
                    Connect();

                var sqlCommand = new MySqlCommand(query, _connection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _needConnect = true;
                //TODO: обрбаботать или убрать   
            }
        }


    }
}
