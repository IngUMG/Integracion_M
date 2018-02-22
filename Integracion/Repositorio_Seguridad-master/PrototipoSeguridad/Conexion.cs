using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace PrototipoSeguridad
{
    class Conexion
    {
       public OdbcConnection conexion()
        {
            OdbcConnection con = new OdbcConnection();
            con = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ");
            con.Open();
            return con;        
        }

        public bool comprobacionConexion()
        {
            try
            {
                conexion();
                return true;
            }
            catch (OdbcException ex)
            {
                return false;
            }
        }
    }
}
