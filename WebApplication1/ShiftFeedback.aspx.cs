using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ShiftFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string shifts = null;
            List<Shift> shiftList = new List<Shift>();

            string shiftManager = Handler.getUserName();
            string connectionString = "server=cmcc_mysqldd.iil.intel.com;port=3310;uid=cmcc_admin;pwd=cmcc_admin;database=CMCC_Ind;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM SMS_Table WHERE Shift_Manager='" + shiftManager + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    TableRow tRow = new TableRow();
                    myTable.Rows.Add(tRow);
                    for (int i =0; i <= 3; i++)
                    {
                        // Create a new cell and add it to the row.
                        TableCell tCell = new TableCell();
                        tCell.Text = rdr.GetString(i);
                        tRow.Cells.Add(tCell);
                    }
                    /* iterate once per row */
                }
            }
        }
    }
}