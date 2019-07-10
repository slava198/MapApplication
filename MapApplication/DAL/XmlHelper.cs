using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;
using System.Globalization;
using System.Xml;
using MapApplication.Entities;

namespace MapApplication.DAL
{
    public static class XmlHelper
    {
        static readonly string CourceURL = "http://www.obmennik.by/xml/kurs.xml";

        public static void Serialize<T>(string fileName, Collection<T> item)
        {
            using (FileStream file = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Collection<T>), new XmlRootAttribute("Banks"));
                xmlSerializer.Serialize(file, item);
            }
        }

        public static Collection<T> Deserialize<T>(string fileName)
        {
            using (FileStream file = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Collection<T>), new XmlRootAttribute("Banks"));
                return (Collection<T>)xmlSerializer.Deserialize(file);
            }
        }


        public static List<Departmen> DeserializeDepartments(string fileName)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            List<Departmen> departmens = new List<Departmen>();

            int _id = 0;
            string _bankName = String.Empty;
            string _address = String.Empty;
            double _latitude = 0;
            double _longitude = 0;

            foreach (XmlNode bankNode in xRoot.ChildNodes)
            {
                _bankName = bankNode.Attributes.GetNamedItem("name").InnerText;

                foreach (XmlNode departmentNode in bankNode.ChildNodes)
                {
                    foreach (XmlNode field in departmentNode.ChildNodes)
                    {
                        if (field.Name == "id")
                        {
                            _id = Int32.Parse(field.FirstChild.InnerText);
                        }
                        if (field.Name == "address")
                        {
                            _address = field.InnerText;
                        }

                        if (field.Name == "latitude")
                        {
                            _latitude = Double.Parse(field.FirstChild.InnerText, CultureInfo.InvariantCulture);
                        }

                        if (field.Name == "longitude")
                        {
                            _longitude = Double.Parse(field.FirstChild.InnerText, CultureInfo.InvariantCulture);
                        }
                    }

                    departmens.Add(new Departmen()
                    {
                        id = _id,
                        bankName = _bankName,
                        address = _address,
                        latitude = _latitude,
                        longitude = _longitude
                    });
                }
            }
            return departmens;
        }


        public static List<Course> DeserializeCourse()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(CourceURL);
            XmlElement xRoot = xDoc.DocumentElement;
            List<Course> courses = new List<Course>();
            DateTime date = DateTime.Now;
            TimeSpan time = DateTime.Now.TimeOfDay;

            int bankID = 0;
            double usdSell = 0;
            double usdBuy = 0;
            double eurSell = 0;
            double eurBuy = 0;
            double rurSell = 0;
            double rurBuy = 0;

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "idbank")
                    {
                        bankID = Int32.Parse(childnode.FirstChild.InnerText);
                    }
                    if (childnode.Name == "date")
                    {
                        date = DateTime.Parse(childnode.InnerText).Date;
                    }

                    if (childnode.Name == "time")
                    {
                        time = DateTime.Parse(childnode.InnerText).TimeOfDay;
                    }

                    if (childnode.Name == "usd")
                    {
                        usdSell = Double.Parse(childnode.FirstChild.InnerText, CultureInfo.InvariantCulture);
                        usdBuy = Double.Parse(childnode.LastChild.InnerText, CultureInfo.InvariantCulture);
                    }

                    if (childnode.Name == "eur")
                    {
                        eurSell = Double.Parse(childnode.FirstChild.InnerText, CultureInfo.InvariantCulture);
                        eurBuy = Double.Parse(childnode.LastChild.InnerText, CultureInfo.InvariantCulture);
                    }

                    if (childnode.Name == "rur")
                    {
                        rurSell = Double.Parse(childnode.FirstChild.InnerText, CultureInfo.InvariantCulture);
                        rurBuy = Double.Parse(childnode.LastChild.InnerText, CultureInfo.InvariantCulture);
                    }
                }

                courses.Add(new Course()
                {
                    BankID = bankID, Date = date, Time = time,
                    USD = new Currency { Name = "USD", Buy = usdBuy, Sell = usdSell },
                    EUR = new Currency { Name = "EUR", Buy = eurBuy, Sell = eurSell },
                    RUR = new Currency { Name = "RUR", Buy = rurBuy, Sell = rurSell }
                });
            }
            return courses;
        }
    }
}
