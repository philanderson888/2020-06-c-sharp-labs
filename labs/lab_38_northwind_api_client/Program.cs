using lab_38_northwind_api_client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace lab_38_northwind_api_client
{
    class Program
    {

        static List<Customer> customers = new List<Customer>();
        static Customer customer = new Customer();
        static Uri url = new Uri("https://localhost:44318/api/Customers");

        static void Main(string[] args)
        {
            Thread.Sleep(4000);

            // Async Get One Customer
            GetCustomerAsync("ALFKI");
            Thread.Sleep(3000);
            Console.WriteLine($"customer {customer.CustomerId} has been returned - contact name is {customer.ContactName}");


            // get all customers
            GetCustomersAsync();
            Thread.Sleep(1000);


            // generate a new random customer ID which does not already exist
            // FIVE ALPHA CHARACTERS




            // POST a customer
            var newCustomer = new Customer()
            {
                CustomerId = "NEW08",
                ContactName = "Phil",
                CompanyName = "My company",
                City = "London",
                Country = "UK"
            };            
            PostCustomerAsync(newCustomer);
            Thread.Sleep(2000);




            // update



            // delete (not async)
            //DeleteCustomer(newCustomer.CustomerId);

            // delete (async RETURN VOID)
            //DeleteCustomerAsync(newCustomer.CustomerId);

            // delete (async RETURN TASK)
            // DeleteCustomerAsync2(newCustomer.CustomerId).Wait();

            // or

            var response = DeleteCustomerAsync2(newCustomer.CustomerId);
            //if (response.IsSuccessStatusCode)
            //{
            //    Console.WriteLine($"record successfully deleted and awaited for");
            //}




            // get all customers - reset 
            customers = null;
            GetCustomersAsync();
            Thread.Sleep(2000);

            customers.ForEach(c => Console.WriteLine($"{c.CustomerId}"));

        }


        static async void GetCustomerAsync(string customerId)
        {
            customer = null;
            using (var httpclient = new HttpClient())
            {
                var customerData = await httpclient.GetStringAsync($"{url}/{customerId}");
                customer = JsonConvert.DeserializeObject<Customer>(customerData);
            }
        }

        static void GetCustomer(string customerId)
        {
            customer = null;
            using (var httpclient = new HttpClient())
            {
                var customerData = httpclient.GetStringAsync($"{url}/{customerId}");
                if (customerData.Result != null)
                {
                    customer = JsonConvert.DeserializeObject<Customer>(customerData.Result);
                }
            };
        }

        static bool CustomerExists(string customerId)
        {
            customer = null;
            customer = customers.Find(c => c.CustomerId == customerId);
            if (customer != null)
            {
                return true;
            }
            else {
                return false;

            }
        }

        static async void GetCustomersAsync()
        {
            using (var httpclient = new HttpClient())
            {
                var customerData = await httpclient.GetStringAsync(url);
                customers = JsonConvert.DeserializeObject<List<Customer>>(customerData);
            }
        }
        
        static async void PostCustomerAsync(Customer newCustomer)
        {
            // check customer does not exist
            if(!CustomerExists(newCustomer.CustomerId))
            {
                // firstly serialise our customer to JSON
                string newCustomerAsJson = JsonConvert.SerializeObject(newCustomer);
                // convert this to http
                var httpcontent = new StringContent(newCustomerAsJson);
                // add headers before send
                httpcontent.Headers.ContentType.MediaType = "application/json";
                httpcontent.Headers.ContentType.CharSet = "UTF-8";

                // send data
                using (var httpclient = new HttpClient())
                {
                    var httpresponse = await httpclient.PostAsync(url, httpcontent);
                    Console.WriteLine($"Success status is {httpresponse.IsSuccessStatusCode}");
                    if (httpresponse.IsSuccessStatusCode == true)
                    {
                        Console.WriteLine($"Customer added with ID {newCustomer.CustomerId}");
                        customers.Add(newCustomer);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Customer already exists - {newCustomer.CustomerId}");
            }



             
        }

        static void DeleteCustomer(string customerId)
        {
            if (CustomerExists(customerId))
            {
                using (var httpclient = new HttpClient())
                {
                    var response = httpclient.DeleteAsync($"{url}/{customerId}");
                    if (response.Result.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"record {customerId} successfully deleted");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Customer {customerId} does not exist so cannot be deleted");
            }

        }


        static async void DeleteCustomerAsync(string customerId)
        {
            if (CustomerExists(customerId))
            {
                using (var httpclient = new HttpClient())
                {
                    var response = await httpclient.DeleteAsync($"{url}/{customerId}");
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"record {customerId} successfully deleted");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Customer {customerId} does not exist so cannot be deleted");
            }

        }


        static async Task<HttpResponseMessage> DeleteCustomerAsync2(string customerId)
        {
            if (CustomerExists(customerId))
            {
                using (var httpclient = new HttpClient())
                {
                    var response = await httpclient.DeleteAsync($"{url}/{customerId}");
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"record {customerId} successfully deleted");
                    }
                    return response;
                }
            }
            else
            {
                Console.WriteLine($"Customer {customerId} does not exist so cannot be deleted");
                return null;
            }
        }


    }
}
