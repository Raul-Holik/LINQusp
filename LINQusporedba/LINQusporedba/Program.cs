using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LINQusporedba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pog = 0;

            XmlDocument prvi = new XmlDocument();
            prvi.Load("C:\\Users\\Osoba\\Documents\\Skola\\LINQusporedba\\prvi.xml");
            XmlNodeList elemList1 = prvi.GetElementsByTagName("book");

            XmlDocument drugi = new XmlDocument();
            drugi.Load("C:\\Users\\Osoba\\Documents\\Skola\\LINQusporedba\\drugi.xml");
            XmlNodeList elemList2 = drugi.GetElementsByTagName("book");


            Console.WriteLine("Issued\tIssue type\t\tIssueInFirst\tIssueInSecond");
            for (int j = 0; j < elemList1.Count; j++)
            {
                for (int i = 0; i < (elemList1.Count - 1); i++)
                {
                    string attrVal1 = elemList1[j].Attributes[i].Value;
                    string attrVal2 = elemList2[j].Attributes[i].Value;
                    if (attrVal2 != attrVal1)
                    {
                        pog++;
                        Console.WriteLine(pog + " \t\tRazlika u elementu " + elemList1[j].Attributes[i].Name + "    \t\t" + attrVal1 + "\t\t\t" + attrVal2);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
