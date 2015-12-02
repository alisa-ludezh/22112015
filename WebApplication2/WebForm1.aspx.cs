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
        struct DayTimeType
        {
            public string Name;
            public string FullName;
            public byte Code;
            public string ColorStr;
        };

        
        public string xx;
        public MyService.MyWebService proxy;

        protected void Page_Load(object sender, EventArgs e)
        {
            //MyService.MyWebService proxy =
            proxy =
                new MyService.MyWebService();
            if (!this.IsPostBack)
            {
                Application["VizitorsCount"] = (int)Application["VizitorsCount"] + 1;
            }

        }

        private void Proxy_HelloWorldAverageCompleted(object sender, MyService.HelloWorldAverageCompletedEventArgs e)
        {
            xx = e.Result;
            this.Response.SetCookie(
                new HttpCookie("Name", xx.GetHashCode().ToString()) {Expires = DateTime.Now.AddHours(2) });
            ViewState["xx"] = xx;
            this.Label1.Text = xx;
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
            List<DayTimeType> TypesDictionary = (List<DayTimeType>)Cache["TypesDictionary"];
            if (TypesDictionary == null)
            {
                TypesDictionary = new List<DayTimeType>()
                {
                    new DayTimeType { Name = "K",  ColorStr ="913D88"},
                    new DayTimeType { Name = "ПК", ColorStr = "9B59B6"},
                    new DayTimeType { Name = "Я",  ColorStr ="acf3a7"},
                    new DayTimeType { Name = "В",  ColorStr ="C8F7C5"},
                    new DayTimeType { Name = "Б",  ColorStr ="2574A9"},
                    new DayTimeType { Name = "НН", ColorStr = "D91E18"},
                    new DayTimeType { Name = "ОТ", ColorStr = "913D88"},
                    new DayTimeType { Name = "ДО", ColorStr = "F4D03F"},
                    new DayTimeType { Name = "ОЗ", ColorStr = "2574A9"},
                    new DayTimeType { Name = "ОЧ", ColorStr = "D91E18"},
                    new DayTimeType { Name = "ОЖ", ColorStr = "F9BF3B"},
                    new DayTimeType { Name = "Р",  ColorStr ="2574A9"},
                    new DayTimeType { Name = "ПМ", ColorStr = "D91E18"},
                    new DayTimeType { Name = "РВ", ColorStr = "913D88"},
                    new DayTimeType { Name = "Д",  ColorStr ="2574A9"},
                    new DayTimeType { Name = "ОД", ColorStr = "D91E18"}
                };
                Cache["TypesDictionary"] = TypesDictionary;
                // Алиса: ручная настройка:
                // Cache.Add("TypesDictionary", TypesDictionary,
                            //null, DateTime.Now.AddHours(2),
                            //TimeSpan.FromMinutes(30), System.Web.Caching.CacheItemPriority.Normal,
                            //null);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            proxy.CustomerListCompleted += Proxy_CustomerListCompleted;
            proxy.CustomerListAsync(this.TextBox1.Text);

        }
        protected void OnColorChanged(object sender, EventArgs e)
        {
            this.TextBox2.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(this.TextBox2_ColorPickerExtender.SelectedColor, 16));
        }

        private void Proxy_CustomerListCompleted(object sender, MyService.CustomerListCompletedEventArgs e)
        {
            this.GridView1.DataSource = e.Result;
            this.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (ViewState["xx"] != null)
            {
                string ssss = (Convert.ToInt32(this.Request.Cookies["Name"].Value)).ToString();
                string sss = ViewState["xx"].ToString();
            }
                if (!String.IsNullOrWhiteSpace(TextBox2.Text))
                {
                    this.Session["UserBackColor"] = TextBox2.Text; // System.Drawing.Color.FromArgb(Convert.ToInt32(this.TextBox2.Text, 16));
                    this.Button3.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(this.Session["UserBackColor"].ToString(), 16));
                    this.Header.Style.Add(HtmlTextWriterStyle.BackgroundColor, "#" + this.Session["UserBackColor"].ToString());
                }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            this.TextBox2.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(this.TextBox2.Text, 16));
        }
    }
}