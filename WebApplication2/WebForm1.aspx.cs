using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public MyService.MyWebService proxy;

        protected void Page_Load(object sender, EventArgs e)
        {
            //MyService.MyWebService proxy =
            proxy =
                new MyService.MyWebService();

        }

        private void Proxy_HelloWorldAverageCompleted(object sender, MyService.HelloWorldAverageCompletedEventArgs e)
        {
            this.Label1.Text = e.Result;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyAsyncMethod();
        }
        protected void MyAsyncMethod()
        {
            //MyService.MyWebService proxy =
            //    new MyService.MyWebService();

            proxy.HelloWorldAverageCompleted += Proxy_HelloWorldAverageCompleted;
            int a = 5;
            int b = 3;
            proxy.HelloWorldAverageAsync(a, b);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            proxy.CustomerListCompleted += Proxy_CustomerListCompleted;
            proxy.CustomerListAsync(this.TextBox1.Text);

        }

        private void Proxy_CustomerListCompleted(object sender, MyService.CustomerListCompletedEventArgs e)
        {
            this.GridView1.DataSource = e.Result;
            this.DataBind();
        }
    }
}