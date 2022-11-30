using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstWebAppn
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string button = "";
            for (int i = 0; i < 10; i++) 
            {
                button += "<button> Nsreen </button> <br>";
            }
            Response.Write(button);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label label= new Label();
            this.Controls.Add(label);
            label.Text = "Hello";
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.Text = string.Format(TextBox3.Text);
        }
    }
}