using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Configuration;
using System.Text;


namespace _5_phase
{
    public partial class header : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginin_Click(object sender, EventArgs e)
        {
            if (TextLogin.Text == "admin@admin.lt" && TextPassword.Text == "admin")
            {
                Session["login"] = TextLogin.Text;               
                Response.Redirect("index.aspx");
                ShowMessage("Logged in!");
            }
            else
            {
                ShowMessage("Login or password is wrong!");
            }
        }

        void ShowMessage(string msg)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('" + msg + "');</script>");
        }


    }
}