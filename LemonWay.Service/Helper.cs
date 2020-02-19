using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace LemonWay.Service
{
    public static class Helper
    {
        // il faut noter que j'ai utilisé le type décimal car à partir du Fibonacci(47) on est plus dans le type int
        public static decimal Fibonacci(int n)
        {
            if (n < 0 || n > 100)
                return -1;
            if (n == 0 || n == 1)
                return n;

            decimal a = 0;
            decimal b = 1;
            while(--n > 0)
            {
                decimal temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }

        public static string XmlToJson(string xml)
        {
            string json = string.Empty;
            try
            {
                XmlDocument document = new XmlDocument();
                document.LoadXml(xml);
                json = JsonConvert.SerializeXmlNode(document);
            }
            catch
            {
                json = "Bad Xml format";
            }
            return json;
        }
    }
}