using Grpc.Core;
using GrpcService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();

            if (request.Userid == 1)
            {
                output.FirstName = "Max";
                output.LastName = "Mustermann";
            }
            else if (request.Userid == 2)
            {
                output.FirstName = "Harald";
                output.LastName = "Schmitt";
            }
            else if (request.Userid == 3)
            {
                output.FirstName = "Karl";
                output.LastName = "Gustav";
            }

            return Task.FromResult(output);
        }


        public override async Task GetCustomers(NewCustomerRequest request, IServerStreamWriter<CustomerModel> responseStream, ServerCallContext context)
        {
            List<CustomerModel> customers = new List<CustomerModel>
            {
                new CustomerModel
                {
                    FirstName = "Kevin",
                    LastName = "Winter",
                    EmailAddress = "KevinW@ppedv.de",
                    Age = 36,
                    IsAlive = false
                },
                new CustomerModel
                {
                    FirstName = "Maxi",
                    LastName = "Musterli",
                    EmailAddress = "maxm@ppedv.de",
                    Age = 34,
                    IsAlive = false
                },
                 new CustomerModel
                {
                    FirstName = "Tina",
                    LastName = "Muster",
                    EmailAddress = "Tinam@ppedv.de",
                    Age = 33,
                    IsAlive = false
                }
            };

            foreach (var cust in customers)
            {
                await responseStream.WriteAsync(cust);
            }
        }
    }
}
