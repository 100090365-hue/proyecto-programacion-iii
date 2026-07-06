using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Diseño_Trabajo_final
{
    class Conexion
    {
        // ⚠️ CAMBIA "TU_SERVIDOR" por el nombre de tu PC o instancia SQL Server
        // Ejemplos:
        //   "Server=localhost\\SQLEXPRESS;..."   → si usas SQL Express local
        //   "Server=.\\SQLEXPRESS;..."           → punto = máquina local
        //   "Server=MSI\\SQLEXPRESS;..."         → tu PC original
        //private static readonly string cadena =
        //    "Server=(local)\\SQLEXPRESS;Database=GestionEventos;Trusted_Connection=True;TrustServerCertificate=True;";
        private static readonly string cadena =
            "Server=LDEVELOPER13\\SQLEXPRESS01;Database=GestionEventos;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConectar()
        {
            return new SqlConnection(cadena);
        }
    }
}