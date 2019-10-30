using System.Threading.Tasks;
using RestSharp;

namespace MessageBoard.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCallGroupIndex()
    {
      RestClient client = new RestClient("http://localhost:4000/api/group");
      RestRequest request = new RestRequest(Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> ApiCallPostIndex()
    {
      RestClient client = new RestClient("http://localhost:4000/api/post");
      RestRequest request = new RestRequest(Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> ApiCallNewUser()
    {
      RestClient client = new RestClient("http://localhost:400/users/create");
      RestRequest request = new RestRequest(Method.POST);
      var response = await client.ExecutePostTaskAsync(request);
      return response.Content;
      
    }
  }
}