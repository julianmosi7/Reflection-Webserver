using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    class NorthwindController
    {
        public string Index()
        {
            return $"{GetType().FullName}::{MethodBase.GetCurrentMethod().Name}";
        }
        public string Get(int id)
        {
            return $"{GetType().FullName}::{MethodBase.GetCurrentMethod().Name}({id})";
        }
        public string GetOrders(int employeeId, string customerId)
        {
            return $"{GetType().FullName}::{MethodBase.GetCurrentMethod().Name}({employeeId},{customerId})";
        }
    }
}
