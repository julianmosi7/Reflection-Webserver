using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    public class HomeController
    {
        public string Index()
        {
            return $"{GetType().FullName}::{MethodBase.GetCurrentMethod().Name}";
        }
    }
}
