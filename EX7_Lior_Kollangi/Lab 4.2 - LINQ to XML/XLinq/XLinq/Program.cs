using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = from t in typeof(string).Assembly.GetExportedTypes()                        
                        where t.IsClass 
                        let properties = t.GetProperties()
                        select new XElement("Type", 
                            new XAttribute("FullName=",t.FullName),                            
                            new XElement("Properties",
                               from p in properties 
                                select new XElement("Property", 
                                    new XAttribute("Name=",p.Name),
                                    new XAttribute("Type=",p.PropertyType.FullName))),

                                    new XElement("Methods",
                               from m in t.GetMethods()
                                select new XElement("Method", 
                                    new XAttribute("Name=",m.Name),
                                    new XAttribute("ReturnType=",m.ReturnType.FullName),

                                     new XElement("Parameters",
                               from param in m.GetParameters()
                                select new XElement("Parameter", 
                                    new XAttribute("Name=",param.Name),
                                    new XAttribute("Type=",param.ParameterType))))));

                                    var xmltypes = new XElement("Types", types);
		                        	Console.WriteLine(xmltypes);


        }
    }
}
