using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAPService
{
    public class Service1 : IService1
    {
        public string Message()
        {
            return "Hello world, this is my first WCF web service.";
        }

        public int add(int x, int y)
        {
            return x + y;

        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
