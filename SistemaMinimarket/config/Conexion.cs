using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaMinimarket.config
{
    public class Conexion
    {
        private SqlConnection Conexion = new SqlConnection("server=DAVIDPC;Initial Catalog=DBCARRITO;Integratedsecurity=TRUE ");
        //Creamos un método para conectar los datos
        public SqlConnection Abrir() { 
        
                if (Conexion.State == ConnectionState.Closed) {
                Conexion.Open();
            }return Conexion;
        }

        public SqlConnection Cerrar()
        {
                if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

    }
}
