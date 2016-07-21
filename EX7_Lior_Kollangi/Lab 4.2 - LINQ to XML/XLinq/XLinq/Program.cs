using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                        where t.IsClass | t.IsPublic
                        let properties = t.GetProperties()
                        select new XElement("Type",
                            new XAttribute("FullName", t.FullName),
                            new XElement("Properties",
                               from p in properties
                               select new XElement("Property",
                                   new XAttribute("Name", p.Name),
                                   new XAttribute("Type", p.PropertyType.FullName ?? "T"))),

                                    new XElement("Methods",
                               from m in t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                               select new XElement("Method",
                                   new XAttribute("Name", m.Name),
                                   new XAttribute("ReturnType", m.ReturnType.FullName ?? "T"),

                                    new XElement("Parameters",
                              from param in m.GetParameters()
                              select new XElement("Parameter",
                                   new XAttribute("Name", param.Name),
                                   new XAttribute("Type", param.ParameterType))))));

            var xmlTypes1 = new XElement("Types", types);
            xmlTypes1.Save("xmlTypes1.xml");

            var typesWithoutProprties = from t in types
                                        where t.Element("Properties").Descendants().Count() == 0
                                        let name = (string)t.Attribute("FullName")
                                        orderby name
                                        select name;
            foreach (var type in typesWithoutProprties)
            {
                Console.WriteLine("The type {0} has no properties", type);
            }
            Console.WriteLine("number of types without proprties: {0}", typesWithoutProprties.Count());

            Console.WriteLine("number of methods not including inherited ones: {0}", types.Sum(t => t.Descendants("Method").Count()));

             Console.WriteLine("number of proprties: {0}", types.Sum(t => t.Descendants("Property").Count()));

            var mostCommonTypeAsParamater = from e in types.Descendants("Parameter")
                                            group e
                                            by (string)e.Attribute("Type")
                                            into g
                                            orderby g.Count() descending
                                            select new
                                            {
                                                Name = g.Key,
                                                count = g.Count()

                                            };
            Console.WriteLine("most paramater type name: {0} count: {1}", mostCommonTypeAsParamater.First().Name, mostCommonTypeAsParamater.First().count);


            var TypesSortedByMethods = from t in types
                                       let methods = t.Descendants("Methods").Count()
                                       orderby methods descending
                                       select new
                                       {
                                           Name = (string)t.Attribute("FullName"),
                                           Methods = methods,
                                           Properties = t.Descendants("Property").Count()
                                       };

            //var MethodsInfo = from m in xmlTypes1.Descendants("Method")
            //                  group m by m.Parent.Parent.Attribute("Name") into g
            //                  select new
            //                  {
            //                      TypeName = g.Key,
            //                      Count = g.Count()
            //                  };
            //var PropertyInfo = from p in xmlTypes1.Descendants("Property")
            //                   group p by p.Parent.Parent.Attribute("Name") into g
            //                   select new
            //                   {
            //                       TypeName = g.Key,
            //                       Count = g.Count()
            //                   };
            //var xmlTypes2 = new XElement("Types", from metodsGroup in MethodsInfo
            //                                        from propertyGroup in PropertyInfo
            //                                        where metodsGroup.TypeName == propertyGroup.TypeName
            //                                        orderby metodsGroup.Count descending
            //                                        select new XElement("Type", new XAttribute("Name", (string)metodsGroup.TypeName ?? "T"),
            //                                                                    new XAttribute("Methods", metodsGroup.Count),
            //                                                                    new XAttribute("Properties", propertyGroup.Count )));



            //xmlTypes2.Save("xmlTypes2.xml");

           // foreach (var i in TypesSortedByMethods)
            // Console.WriteLine(i);







            var typsGroupByMethods = from t in types
                                    let methods = t.Descendants("Method").Count()
                                    orderby (string)t.Attribute("FullName")
                                    group new
                                    {
                                        Methods = methods,
                                        Properties = t.Descendants("Property").Count(),
                                        Name = (string)t.Attribute("FullName")

                                    }
                                    by methods
                                    into g
                                    orderby g.Key descending
                                    select g;
            foreach (var g in typsGroupByMethods)
            {
                Console.WriteLine("Methods: {0}", g.Key);
                foreach (var i in g)
                    Console.WriteLine("{0} ({1} Properties)", i.Name, i.Properties);
            }


        }

    }
    
}
