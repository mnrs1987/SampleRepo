using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mathlib;

namespace SampleApp
{
    public partial class Addition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                math math = new math();
                Int32 value1 = Convert.ToInt32(addValue1.Text.ToString());
                Int32 value2 = Convert.ToInt32(addValue2.Text.ToString());
                Int32 sum = math.Add(value1, value2);
                sumValue.Text = "Sum of two values are : " + sum.ToString();
                sumValue.ForeColor = System.Drawing.Color.White;
            }
            catch
            {
                sumValue.Text = "Input Error";
                sumValue.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subtract.aspx");
        }

        protected void linkMultiply_Click(object sender, EventArgs e)
        {
            Response.Redirect("Multiply.aspx");
        }
    }
}