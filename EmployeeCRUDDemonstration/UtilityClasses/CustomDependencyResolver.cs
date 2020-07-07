using EmployeeCRUDDemonstration.Contracts;
using EmployeeCRUDDemonstration.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeCRUDDemonstration.UtilityClasses
{
    public class CustomDependencyResolver : IDependencyResolver
    {
        readonly IKernel kernel;

        public CustomDependencyResolver()
        {
            kernel = new StandardKernel();
            
            kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();

            kernel.Bind<ITest>().To<TestClass>().WithConstructorArgument("x",100)
                .WithPropertyValue("Name","Utpal Technologies");
        }
        public object GetService(Type serviceType)
        {
            try
            {
                return kernel.Get(serviceType);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return kernel.GetAll(serviceType);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
    }
}