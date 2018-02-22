using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace bitacora_dll
{

    public class bitacora_dll
    {
        private OdbcConnection conn;
        private String connStr;

        public bitacora_dll(String coonection)
        {
            this.connStr = coonection;
        }
        
        public bool OpenConnection()
        {
            try
            {
                conn = new OdbcConnection(connStr);
                conn.Open();
                return true;
            }
            catch (OdbcException)
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                return true;
            }
            catch (OdbcException )
            {
                return false;
            }
        }


        public System.Data.DataTable llenarBitacora(String sentencia)
        {
            OdbcConnection MyConn2 = new OdbcConnection(connStr);
            OdbcCommand MyCommand2 = new OdbcCommand(sentencia, MyConn2);
            OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            System.Data.DataTable dTable = new System.Data.DataTable();
            MyAdapter.Fill(dTable);
            return dTable;
        }


        public void InsertarRegistro(String sentencia)
        {
            string insertquery = sentencia;
            OdbcCommand command = new OdbcCommand(insertquery, conn);
            command.ExecuteNonQuery();
        }

        public void InsertarError(String sentencia)
        {
            string insertquery = sentencia;
            OdbcCommand commandd = new OdbcCommand(insertquery, conn);
            commandd.ExecuteNonQuery();
        }



    }
}
