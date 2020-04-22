using System;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcService;
using GrpcService.Protos;

namespace GrpcClient
{
    class Program
    {
        static async Task  Main(string[] args)
        {
            #region SayHello Sample
            //var input = new HelloRequest { Name = "Kevin" };
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Greeter.GreeterClient(channel);
            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);
            #endregion


            #region Sample 2 - Complexe Object
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var customerClient = new Customer.CustomerClient(channel);
            var clientRequest = new CustomerLookupModel { Userid = 2 };

            var customer = await customerClient.GetCustomerInfoAsync(clientRequest);
            Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            #endregion

            #region Sample 3 - Streamen einer Liste
            using (var call = customerClient.GetCustomers(new NewCustomerRequest()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;

                    Console.WriteLine($"{currentCustomer.FirstName} {currentCustomer.LastName}:{currentCustomer.EmailAddress}");
                }
            }
            #endregion
                
            Console.ReadLine();

        }
    }
}
