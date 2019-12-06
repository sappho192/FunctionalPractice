using System.Collections.Generic;

namespace BasicExercise
{
    namespace Delegate
    {
        public class Customer
        {
            public static List<Customer> allCustomers = new List<Customer>();
            public int id = 0;
            public string name = "";
            public string address = "";
            public string state = "";
            public string primarycontact = "";
            public string domain = "";
            public bool enabled = true;

            public Customer() { }

            public static List<string> getEnabledCustomerAddresses()
            {
                // Solution with "delegate" (C# 2.0)
                return getEnabledCustomerField(
                    delegate (Customer customer) { return customer.address; });
            }

            public static List<string> getEnabledCustomerNames()
            {
                // Solution with "Lambda Expression" (C# 3.0)
                return getEnabledCustomerField(
                    (Customer customer) => { return customer.name; });
            }

            public static List<string> getEnabledCustomerStates()
            {
                // More simple syntax of Lambda Expression
                return getEnabledCustomerField(
                    customer => { return customer.state; });
            }

            public static List<string> getEnabledCustomerPrimaryContacts()
            {
                return getEnabledCustomerField(
                    customer => { return customer.primarycontact; });
            }

            public static List<string> getEnabledCustomerDomains()
            {
                return getEnabledCustomerField(
                    customer => { return customer.domain; });
            }

            private static List<B> getEnabledCustomerField<B>(Function1<B, Customer> getField)
            {
                List<B> outList = new List<B>();

                foreach (var customer in Customer.allCustomers)
                {
                    if (customer.enabled)
                    {
                        outList.Add(getField(customer));
                    }
                }

                return outList;
            }
        }
    }
}
