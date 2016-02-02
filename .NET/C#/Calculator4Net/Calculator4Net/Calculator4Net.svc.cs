using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Calculator4Net
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator4Net" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator4Net.svc or Calculator4Net.svc.cs at the Solution Explorer and start debugging.
    public class Calculator4Net : ICalculator4Net
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Divide(double num1, double num2)
        {
            if(num1 != 0 && num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                return 0;
            }
        }

        public string GetToken()
        {
            var userToken = new AuthToken
            {
                Token = "mastermind",
                CreatedDate = DateTime.Now,
                Roles = new List<string>
                  {
                    "User",
                    "Admin"
                  }
            };
            return JsonConvert.SerializeObject(userToken);
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }


        
    }
}
