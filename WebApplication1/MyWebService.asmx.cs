using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data; // alisa! for sqlCommand
using System.Data.SqlClient;
using System.Configuration; //alisa for Web.config
using System.Xml.Linq; // for linq to xml (XElement)

namespace WebApplication1
{
    /// <summary>
    /// Сводное описание для MyWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod]
        public string HelloWorldAverage(int a, int b)
        {
            return ((a+ b)/2M).ToString();
        }
        [WebMethod]
        public List<XNode[]> CustomerList(string CountryName)
        {
            /// sql-запрос:
            /// 
            //string conString = 
            //    ConfigurationManager.ConnectionStrings["CustomerManagment"].ConnectionString;
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //string sqlQuery = "SELECT * FROM Countries";
            //SqlCommand sqlComm = new SqlCommand(sqlQuery, con);
            //SqlDataReader reader = sqlComm.ExecuteReader();
            
            /// LINQ-запрос
            XElement doc = XElement.Load(Server.MapPath("Countries.xml"));
            XElement doc2 = XElement.Load(Server.MapPath("Customers.xml"));
            //var bb =
            //    (from aa in doc2.Elements("Customers")
            //    where aa.Element("Country").Value ==
            //        ((from c in doc.Elements("Countries")
            //         where String.Equals(CountryName, c.Element("CountryName").Value, StringComparison.OrdinalIgnoreCase) == true
            //          select c.Element("ID").Value).FirstOrDefault())
            //    select aa.Value).ToArray();
            var bb =
                (from aa in doc2.Elements("Customers")
                 where aa.Element("Country").Value ==
                     ((from c in doc.Elements("Countries")
                       where String.Equals(CountryName, c.Element("CountryName").Value, StringComparison.OrdinalIgnoreCase) == true
                       select c.Element("ID").Value).FirstOrDefault())
                 select aa.Element("Nname").Value).ToArray();
            //var ccc =
            //    from aln in ((from aa in doc2.Elements("Customers")
            //    where aa.Element("Country").Value ==
            //     ((from c in doc.Elements("Countries")
            //       where String.Equals(CountryName, c.Element("CountryName").Value, StringComparison.OrdinalIgnoreCase) == true
            //       select c.Element("ID").Value).FirstOrDefault())
            //     select aa.Nodes()).ToArray())
            //     select aln["Name"];

            //var bbb =
            //    (from aa in doc2.("Customers") select aa).ToArray();
            //where aa.Element("Country").Value == "34643-4636-37"

            var fin = (from aa in doc2.Elements("Customers") select aa.Nodes().ToArray()).ToList();

            string[] a = bb;
            //string[] ab = bb.ToArray();
            //con.Close();
            return fin;
        }
    
    }
}
