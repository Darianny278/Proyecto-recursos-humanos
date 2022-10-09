using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_recursos_humanos.DBContext
{
    internal class DBSqlite
    {
        public string url = @"data source=C:\Users\Darianny Peguero\Source\Repos\Proyecto recursos humanos\Proyecto recursos humanos\DBProyectoFinal.db";
        public void openConnection()
        {
            SQLiteConnection con = new SQLiteConnection(url);
            con.Open();

            string query = "select * from idiomas";

            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);

            

        }
    }
}
