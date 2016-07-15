using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class MyExtension
    {
        public static void CopyTo(this object fromObj, object toObj)
        {
            var properties = from p in fromObj.GetType().GetProperties()
                             from q in toObj.GetType().GetProperties()
                             where p.Name == q.Name && p.CanRead && q.CanRead && q.CanWrite && p.PropertyType == q.PropertyType
                             select new
                             {
                                 fromProp = p,
                                 toProp = q
                             };
            foreach (var p in properties)
                p.toProp.SetValue(fromObj, p.fromProp.GetValue(fromObj, null), null);


        }

    }
}
