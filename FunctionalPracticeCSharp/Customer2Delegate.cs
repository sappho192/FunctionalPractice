using System.Collections.Generic;
using System.Linq;

namespace FunctionalPracticeCSharp
{
    namespace Delegate
    {
        public class Customer2
        {
            public static List<Customer2> allCustomers = new List<Customer2>();
            public int id = 0;
            public string name = "";
            public string address = "";
            public string state = "";
            public string primarycontact = "";
            public string domain = "";
            public bool enabled = true;

            public Customer2() { }

            public static readonly Function1<bool, Customer2> isEnabled =
                customer => { return customer.enabled; };
            public static readonly Function1<bool, Customer2> isDisabled =
                customer => { return !customer.enabled; };

            public static List<string> getCustomerAddresses(
                Function1<bool, Customer2> condition)
            {
                return getFieldWithCondition(condition,
                    customer => { return customer.address; });
            }

            public static List<string> getCustomerNames(
                Function1<bool, Customer2> condition)
            {
                return getFieldWithCondition(condition,
                    customer => { return customer.name; });
            }

            public static List<string> getCustomerStates(
                Function1<bool, Customer2> condition)
            {
                return getFieldWithCondition(condition,
                    customer => { return customer.state; });
            }

            public static List<string> getCustomerPrimaryContacts(
                Function1<bool, Customer2> condition)
            {
                return getFieldWithCondition(condition,
                    customer => { return customer.primarycontact; });
            }

            public static List<string> getCustomerDomains(
                Function1<bool, Customer2> condition)
            {
                return getFieldWithCondition(condition,
                    customer => { return customer.domain; });
            }

            private static List<B> getFieldWithCondition<B>(
                Function1<bool, Customer2> condition,
                Function1<B, Customer2> getField)
            {
                // using LINQ
                var x = from customer in allCustomers
                        where condition(customer)
                        select getField(customer);

                return x.ToList();
            }
        }
    }
}
