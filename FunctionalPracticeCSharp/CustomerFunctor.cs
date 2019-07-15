using System.Collections.Generic;

namespace FunctionalPracticeCSharp
{
    namespace Functor
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
                return getEnabledCustomerField(new CustomerAddress());
            }

            public static List<string> getEnabledCustomerNames()
            {
                return getEnabledCustomerField(new CustomerNames());
            }

            public static List<string> getEnabledCustomerStates()
            {
                return getEnabledCustomerField(new CustomerStates());
            }

            public static List<string> getEnabledCustomerPrimaryContacts()
            {
                return getEnabledCustomerField(new CustomerPrimaryContacts());
            }

            public static List<string> getEnabledCustomerDomains()
            {
                return getEnabledCustomerField(new CustomerDomains());
            }

            private static List<B> getEnabledCustomerField<B>(IFunction1<Customer, B> func)
            {
                List<B> outList = new List<B>();

                foreach (var customer in Customer.allCustomers)
                {
                    if (customer.enabled)
                    {
                        outList.Add(func.Call(customer));
                    }
                }

                return outList;
            }

            private class CustomerAddress : IFunction1<Customer, string>
            {
                public string Call(Customer customer) { return customer.address; }
            }

            private class CustomerNames : IFunction1<Customer, string>
            {
                public string Call(Customer customer) { return customer.name; }
            }

            private class CustomerStates : IFunction1<Customer, string>
            {
                public string Call(Customer customer) { return customer.state; }
            }

            private class CustomerPrimaryContacts : IFunction1<Customer, string>
            {
                public string Call(Customer customer) { return customer.primarycontact; }
            }

            private class CustomerDomains : IFunction1<Customer, string>
            {
                public string Call(Customer customer) { return customer.domain; }
            }
        }
    }
}
