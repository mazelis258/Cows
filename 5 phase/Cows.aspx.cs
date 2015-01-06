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
    public partial class Cows : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                if (!IsPostBack)
                {

                    BindData();

                }
            }
        }

        protected void SortRecords(object sender, GridViewSortEventArgs e)
        {

            string sortExpression = e.SortExpression;

            string direction = string.Empty;

            if (SortDirection == SortDirection.Ascending)
            {

                SortDirection = SortDirection.Descending;

                direction = " DESC";

            }

            else
            {

                SortDirection = SortDirection.Ascending;

                direction = " ASC";

            }

            DataTable table = this.GetData();

            table.DefaultView.Sort = sortExpression + direction;

            GridView1.DataSource = table;

            GridView1.DataBind();

        }



        private void BindData()
        {

            // specify the data source for the GridView

            GridView1.DataSource = this.GetData();

            // bind the data now

            GridView1.DataBind();

        }



        /// <summary>

        /// Gets or sets the grid view sort direction.

        /// </summary>

        /// <value>

        /// The grid view sort direction.

        /// </value>

        public SortDirection SortDirection
        {

            get
            {

                if (ViewState["SortDirection"] == null)
                {

                    ViewState["SortDirection"] = SortDirection.Ascending;

                }

                return (SortDirection)ViewState["SortDirection"];

            }

            set
            {

                ViewState["SortDirection"] = value;

            }

        }

        private DataTable GetData()
        {

            DataTable table = new DataTable();

            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM sharp_cows "))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            table = dt;
                        }
                    }
                }
            }

            return table;

        }
    }
}