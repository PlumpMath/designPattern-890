using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class DataAccess
    {
        //private static readonly string db = "Sqlserver";
        ////private static readonly string db = "Access";

        //public static IUser CreateUser()
        //{
        //    IUser result = null;
        //    switch(db)
        //    {
        //        case "Sqlserver":
        //            result = new SqlserverUser();
        //            break;
        //        case "Access":
        //            result = new AccessUser();
        //            break;

        //    }
        //    return result;
        //}

        //public static IDepartment CreateDepartment()
        //{
        //    IDepartment result = null;
        //    switch(db)
        //    {
        //        case "SqlServer":
        //            result = new SqlserverDepartment();
        //            break;
        //        case "Access":
        //            result = new AccessDepartment();
        //            break;
        //    }
        //    return result;
        //}
        private static readonly string AssemblyName = "抽象工厂模式";
        private static readonly string db = "Sqlserver";

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment createDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
