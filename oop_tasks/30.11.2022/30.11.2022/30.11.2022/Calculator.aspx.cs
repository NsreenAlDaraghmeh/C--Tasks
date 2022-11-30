using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30._11._2022
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }

        protected void one(object sender, EventArgs e)
        {
   
        }

        protected void TextNum1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextNum2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            int sum= Int32.Parse(TextNum1.Text)+Int32.Parse(TextNum2.Text);
            Textresult.Text=Convert.ToString(sum);
        }

        protected void Textresult_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnminus_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(TextNum1.Text) - Int32.Parse(TextNum2.Text);
            Textresult.Text = Convert.ToString(min);
        }

        protected void btnmulti_Click(object sender, EventArgs e)
        {
            int mul = Int32.Parse(TextNum1.Text) * Int32.Parse(TextNum2.Text);
            Textresult.Text = Convert.ToString(mul);
        }

        protected void btndevid_Click(object sender, EventArgs e)
        {
            int div = Int32.Parse(TextNum1.Text) / Int32.Parse(TextNum2.Text);
            Textresult.Text = Convert.ToString(div);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TextNum1.Text = "";
            TextNum2.Text = "";
            Textresult.Text = "";
        }
    }
}