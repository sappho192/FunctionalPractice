using System;
using BasicExercise.Functor;

namespace BasicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //testFunctorSolution();
            testDelegateSolution();
            //testCustomer2();
        }

        static void testFunctorSolution()
        {
            Console.WriteLine("Testing Functor solution");
            for (int i = 0; i < 10; i++)
            {
                Functor.Customer customer = new Customer();
                customer.name = "Person " + i;
                customer.address = "Addr" + i;
                customer.domain = "Domain" + i;
                customer.id = i;
                customer.state = "State" + (i % 2);
                customer.primarycontact = string.Format("{0}{1}{2}", i, i, i);
                if(i % 2 == 1) { customer.enabled = false; }
                Functor.Customer.allCustomers.Add(customer);
            }

            var list = Customer.getEnabledCustomerAddresses();
            foreach(var field in list)
            {
                Console.WriteLine(field);
            }
            list = Customer.getEnabledCustomerDomains();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Customer.getEnabledCustomerNames();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Customer.getEnabledCustomerPrimaryContacts();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Customer.getEnabledCustomerStates();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
        }

        static void testDelegateSolution()
        {
            Console.WriteLine("Testing Delegate solution");
            for (int i = 0; i < 10; i++)
            {
                Delegate.Customer customer = new Delegate.Customer();
                customer.name = "Person " + i;
                customer.address = "Addr" + i;
                customer.domain = "Domain" + i;
                customer.id = i;
                customer.state = "State" + (i % 2);
                customer.primarycontact = string.Format("{0}{1}{2}", i, i, i);
                if (i % 2 == 1) { customer.enabled = false; }
                Delegate.Customer.allCustomers.Add(customer);
            }

            var list = Delegate.Customer.getEnabledCustomerAddresses();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Delegate.Customer.getEnabledCustomerDomains();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Delegate.Customer.getEnabledCustomerNames();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Delegate.Customer.getEnabledCustomerPrimaryContacts();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Delegate.Customer.getEnabledCustomerStates();
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
        }

        static void testCustomer2()
        {
            Console.WriteLine("Testing Customer2");
            for (int i = 0; i < 10; i++)
            {
                Delegate.Customer2 customer = new Delegate.Customer2();
                customer.name = "Person " + i;
                customer.address = "Addr" + i;
                customer.domain = "Domain" + i;
                customer.id = i;
                customer.state = "State" + (i % 2);
                customer.primarycontact = string.Format("{0}{1}{2}", i, i, i);
                if (i % 2 == 1) { customer.enabled = false; }
                Delegate.Customer2.allCustomers.Add(customer);
            }

            var list = Delegate.Customer2.getCustomerAddresses(
                Delegate.Customer2.isEnabled);
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Delegate.Customer2.getCustomerDomains(
                Delegate.Customer2.isDisabled);
            foreach (var field in list)
            {
                Console.WriteLine(field);
            }
            list = Delegate.Customer2.getCustomerNames(
                new Delegate.Function1<bool, Delegate.Customer2>(
                    (Delegate.Customer2 customer) => { return customer.state.Equals("State0"); }
                    ));
            foreach (var field in list)
            {
                Console.WriteLine("Name: " + field);
            }
        }

    }
}
