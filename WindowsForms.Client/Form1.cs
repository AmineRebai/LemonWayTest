using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Client
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string fib;
        private string xmltojson;
        private string error;
        private string newInt;
        public Form1()
        {
            InitializeComponent();
        }

        private void FibonacciBtn_Click(object sender, EventArgs e)
        {
                using(WaitForm frm = new WaitForm(FibonacciWork))
                {
                    frm.ShowDialog(this);
                    if (!string.IsNullOrEmpty(newInt))
                    {
                        MessageBox.Show(newInt);
                    }
                    if (string.IsNullOrEmpty(error))
                    {
                        FibonacciRslt.Text = fib;
                    log.Info("Fibonacci de " + FibonacciTxt.Text + " est :" + fib);
                }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
        }

        private void XmlToJsonBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XmlToJsonTxt.Text))
            {
                MessageBox.Show("Le chemps est vide!");
            }
            else
            {
                using(WaitForm frm = new WaitForm(XmlToJsonWork))
                {
                    frm.ShowDialog(this);
                    if (string.IsNullOrEmpty(error))
                    {
                        XmlToJsonRslt.Text = xmltojson;
                        log.Info("Format json de " + XmlToJsonTxt.Text + " est :" + xmltojson);
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
            }
        }

        void FibonacciWork()
        {
            try
            {
                newInt = string.Empty;
                localhost.WebService service = new localhost.WebService();
                int entier;
                if(string.IsNullOrEmpty(FibonacciTxt.Text) || !int.TryParse(FibonacciTxt.Text, out entier))
                {
                    newInt = "Entrer un entier entre 1 et 100";
                }
                else
                {
                    fib = Fibonacci(service, entier).ToString();
                }
                Thread.Sleep(2000);
            }
            catch
            {
                error = "Erreur de compilation!";
                log.Error(error);
            }
        }

        void XmlToJsonWork()
        {
            try
            {
                localhost.WebService service = new localhost.WebService();
                string json = XmlToJson(service, XmlToJsonTxt.Text);
                xmltojson = json;
                error = string.Empty;
                Thread.Sleep(2000);
            }
            catch
            {
                error = "Erreur de compilation!";
                log.Error(error);
            }
        }

        public decimal Fibonacci(localhost.WebService service, int entier)
        {
            return service.Fibonacci(entier);
        }

        public string XmlToJson(localhost.WebService service, string xml)
        {
            return service.XmlToJson(xml);
        }
    }
}
