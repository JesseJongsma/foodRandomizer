using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        label.Visible = false;
    }
    public void randomNumber(object sender, EventArgs e) 
    {
        Random rnd = new Random();
        int random = rnd.Next(0, 100);
        string randomString = Convert.ToString(random);
        label.Text = randomString;
        label.Visible = true;
    }
}