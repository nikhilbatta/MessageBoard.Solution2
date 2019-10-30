using System.Threading.Tasks;
using RestSharp;
using MessageBoard.Entities;
using System;

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
    public static async Task<string> ApiCallNewUser(User1 newUser)
    {
      RestClient client = new RestClient("http://localhost:4000/users/create");
      Console.WriteLine(client);
      Console.WriteLine("this is a console log from apihelper" + newUser.Username);
      RestRequest request = new RestRequest(Method.POST);
      request.AddJsonBody(newUser);
      var response = await client.ExecuteTaskAsync(request);
      System.Console.WriteLine(response.ResponseStatus);
      return response.Content;
      
    }
    public static async Task<string> ApiGetUser(User1 loggedInUser)
    {
      RestClient client = new RestClient("http://localhost:4000/users/authenticate");
      RestRequest request = new RestRequest(Method.POST);
      request.AddJsonBody(loggedInUser);
      var response = await client.ExecuteTaskAsync(request);
      Console.WriteLine(response.ResponseStatus);
      return response.Content;
    }
  }
}