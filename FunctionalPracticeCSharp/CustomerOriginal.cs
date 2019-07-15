using System.Collections.Generic;

namespace FunctionalPracticeCSharp
{
    namespace Original
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
                List<string> outList = new List<string>();

                foreach (var customer in Customer.allCustomers)
                {
                    if (customer.enabled)
                    {
                        outList.Add(customer.address);
                    }
                }

                return outList;
            }

            public static List<string> getEnabledCustomerNames()
            {
                List<string> outList = new List<string>();

                foreach (var customer in Customer.allCustomers)
                {
                    if (customer.enabled)
                    {
                        outList.Add(customer.name);
                    }
                }

                return outList;
            }

            public static List<string> getEnabledCustomerStates()
            {
                List<string> outList = new List<string>();

                foreach (var customer in Customer.allCustomers)
                {
                    if (customer.enabled)
                    {
                        outList.Add(customer.state);
                    }
                }

                return outList;
            }

            public static List<string> getEnabledCustomerPrimaryContacts()
            {
                List<string> outList = new List<string>();

                foreach (var customer in Customer.allCustomers)
                {
                    if (customer.enabled)
                    {
                        outList.Add(customer.primarycontact);
                    }
                }

                return outList;
            }

            public static List<string> getEnabledCustomerCustomerDomains()
            {
                List<string> outList = new List<string>();

                foreach (var customer in Customer.allCustomers)
                {
                    if (customer.enabled)
                    {
                        outList.Add(customer.domain);
                    }
                }

                return outList;
            }
            /// END OF CLASS
        }
    }
}
