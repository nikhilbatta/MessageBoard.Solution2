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
      RestRequest request = new RestRequest(Method.POST);
      request.AddJsonBody(newUser);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
      
    }
    public static async Task<string> ApiGetUser(User1 loggedInUser)
    {
      RestClient client = new RestClient("http://localhost:4000/users/authenticate");
      RestRequest request = new RestRequest(Method.POST);
      request.AddJsonBody(loggedInUser);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> ApiGetSpecificGroup(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest("/group/{id}", Method.GET);
      request.AddUrlSegment("id", id);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> ApiPostToSpecificGroup(Post post)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest("/post/{id}", Method.POST);
      request.AddJsonBody(post);
      request.AddUrlSegment("id", post.GroupId);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> ApiNewGroup(Group group)
    {
      RestClient client = new RestClient("http://localhost:4000/api/group");
      RestRequest request = new RestRequest(Method.POST);
      request.AddJsonBody(group);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}