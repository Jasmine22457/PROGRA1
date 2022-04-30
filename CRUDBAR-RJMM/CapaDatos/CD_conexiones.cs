using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_conexiones
    {
        private SqlConnection conexion = new SqlConnection("server = DESKTOP-L6UIOLI;" +
            "DataBase =BarDb;" + "Integrated security= SSPI");
            
        public SqlConnection OnConexion()
        {
            if (conexion.State== ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection OffConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

    }
}
