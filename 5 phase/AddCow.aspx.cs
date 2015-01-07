using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_phase
{
    public partial class AddCow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("index.aspx");
            }
        }


        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            string CowsNamet = CowsName.Text;
            string CowsNumbert = CowsNumber.Text;
            string CowsBirtht = CowsBirth.Text;
            string CowsDeatht = CowsDeath.Text;
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO sharp_cows (id, nr, vardas, gim_data, mir_data) VALUES (NULL, '"+CowsNumbert
                +"', '"+CowsNamet+"', '"+CowsBirtht+"', '"+CowsDeatht+"')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            Response.Redirect("Cows.aspx");
        }
    }
}