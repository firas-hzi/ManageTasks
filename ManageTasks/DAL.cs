using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageTasks
{
    class DAL
    {
        public static string constr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\ManageTasks-V2\\ManageTasks\\ManageTasks.mdf;Integrated Security=True";
        public static SqlDataAdapter adapter;
        public static DataTable table;
        public static SqlCommandBuilder builder;
        public static SqlConnection con;

        public static int ConnectionEnvironment(string query)
        {
            int affected = 0;
            try
            {
                con = new SqlConnection(constr);
                SqlCommand com = con.CreateCommand();
                con.Open();
                com.CommandText = query;

                //  com = new SqlCommand(query,con);
                //  MessageBox.Show("" + com.ExecuteNonQuery().ToString());
                affected = com.ExecuteNonQuery();
                return affected;
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message.ToString());
                return 0;
            }
            finally { con.Close(); }

        }

        public static DataTable dynamicTConnection(string query)
        {
            try
            {
                con = new SqlConnection(constr);
                adapter = new SqlDataAdapter(query, con);
                con.Open();
                builder = new SqlCommandBuilder(adapter);
                table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }


        }

 

    }
}
