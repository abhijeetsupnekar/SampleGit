using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace HelloWebClient
{
    public partial class HelloServiceWebClientForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloServiceReference.HelloServiceClient client = new HelloServiceReference.HelloServiceClient("BasicHttpBinding_IHelloService");
            Label1.Text= client.Getmessage(TextBox1.Text);


        }
    }
}