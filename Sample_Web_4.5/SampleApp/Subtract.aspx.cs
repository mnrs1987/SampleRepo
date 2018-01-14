using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mathlib;

namespace SampleApp
{
    public partial class Subtract : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            try{
                mathlib.math math = new math();
                Int32 value1 = Convert.ToInt32(subValue1.Text.ToString());
                Int32 value2 = Convert.ToInt32(subValue2.Text.ToString());
                Int32 sub = math.Subtract(value1, value2);
                subValue.Text = "Subtract of two values are : " + sub.ToString();
                subValue.ForeColor = System.Drawing.Color.White;
             }
            catch
            {
                subValue.Text = "Input Error";
                subValue.ForeColor = System.Drawing.Color.Red;
            }
        }


        protected void linkMultiply_Click(object sender, EventArgs e)
        {
            Response.Redirect("Multiply.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addition.aspx");
        }
    }
}