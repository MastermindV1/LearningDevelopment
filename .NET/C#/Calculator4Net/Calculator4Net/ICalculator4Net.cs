using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator4Net
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator4Net" in both code and config file together.
    [ServiceContract]
    public interface ICalculator4Net
    {
        [OperationContract]
        [WebGet]
        double Add(double num1, double num2);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string GetToken();

        [OperationContract]
        [WebGet]
        double Divide(double num1, double num2);

        [OperationContract]
        [WebGet]
        double Multiply(double num1, double num2);

        [OperationContract]
        [WebGet]
        double Subtract(double num1, double num2);

    }
}
