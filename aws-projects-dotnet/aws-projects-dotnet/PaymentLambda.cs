using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using System.Net;

namespace aws_projects_dotnet
{
    internal class PaymentLambda
    {
        public APIGatewayProxyResponse Handler(APIGatewayProxyRequest request)
        {
            var id = request.PathParameters["id"];

            return new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(new
                {
                    Ronaldo = "Hello World",
                    Id = id
                })
            };
        }
    }
}
