using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract(IsOneWay = false)]
        CustomerDetails GetCustomerDetails(CustomerDetails custDetails);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class CustomerDetails
    {
        string custName = default(string);
        string middleName = default(string);
        string age = default(string);
        string emp = default(string);

        [DataMember]
        public string CustomerName
        {
            get { return custName; }
            set { custName = value; }
        }

        [DataMember]
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        [DataMember]
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        [DataMember]
        public string Emp
        {
            get { return emp; }
            set { emp = value; }
        }
    }
}
