using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mathlib;

namespace SampleApp
{
    public partial class Multiply : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try{
                mathlib.math math = new math();
                Int32 value1 = Convert.ToInt32(mulValue1.Text.ToString());
                Int32 value2 = Convert.ToInt32(mulValue2.Text.ToString());
                Int32 mul = math.Multiply(value1, value2);
                mulValue.Text = "Multiply of two values are : " + mul.ToString();
                mulValue.ForeColor = System.Drawing.Color.White;
              }
            catch
            {
                mulValue.Text = "Input Error";
                mulValue.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addition.aspx");
        }

        protected void linkMultiply_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subtract.aspx");
        }
    }
}