using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System.Net;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace Bpd.Order.Processing.Lambda
{
    public sealed class Function
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
