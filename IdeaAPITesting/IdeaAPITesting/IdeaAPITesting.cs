using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Text.Json;
using IdeaAPITesting.Models;


namespace IdeaAPITesting;

public class IdeaAPITests
{
    private RestClient client;
    private const string BASEURL = "http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:84";
    private const string EMAIL = "ivan@ex.com";
    private const string PASSWORD = "test11";

    private static string lastIdeaID;

    [OneTimeSetUp]
    public void Setup()
    {
        string jwtToken = GetJwtToken(EMAIL, PASSWORD);

        var options = new RestClientOptions(BASEURL)
        {
            Authenticator = new JwtAuthenticator(jwtToken)
        };
        client = new RestClient(options);
    }

    private string GetJwtToken(string email, string password)
    {
        RestClient authClient = new RestClient(BASEURL);
        var request = new RestRequest("/api/User/Authentication");
        request.AddJsonBody(new
        {
            email, password

        });
        var response = authClient.Post(request);

        if (response.StatusCode == HttpStatusCode.OK)
        {
            var content = JsonSerializer.Deserialize<JsonElement>(response.Content);
            var token = content.GetProperty("accessToken").GetString();
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new InvalidOperationException("Token is null or empty");
            }

            return token;
        }
        else
        {
            throw new InvalidOperationException($"HTTP Response not OK - {response.StatusCode}, with data  {response.Content}");

        }
    }

    [Test, Order(1)]

    public void CreatNewIdea_WithCOrrectData_ShouldSucceed()
    {
        var requestData = new IdeaDTO()
        {
            Title = "TestTitle",
            Description = "TestDescription"
        };
        var request = new RestRequest("/api/Idea/Create");
        request.AddJsonBody(requestData);

        var response = client.Execute(request, Method.Post);

        var responseData = JsonSerializer.Deserialize<ApiResponseDTO>(response.Content);



        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        Assert.That(responseData.Msg, Is.EqualTo("Successfully created!"));

    }

    [Test, Order(2)]

    public void GetAllIdea_ShouldReturnNonEmptyArray()
    {
        
        var request = new RestRequest("/api/Idea/All");
        

        var response = client.Execute(request, Method.Get);

        var responseDataArray = JsonSerializer.Deserialize<ApiResponseDTO[]>(response.Content);

        

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        Assert.That(responseDataArray.Length, Is.GreaterThan(0));

        lastIdeaID = responseDataArray[responseDataArray.Length - 1].IdeaId;

    }


    [Test, Order(3)]

    public void EditIdea_WithCOrrectData_ShouldSucceed()
    {
        var requestData = new IdeaDTO()
        {
            Title = "EditedTitle",
            Description = "Edited TestDescription"
        };
        var request = new RestRequest($"/api/Idea/Edit");
        request.AddQueryParameter("IdeaId", lastIdeaID);
        request.AddJsonBody(requestData);

        var response = client.Execute(request, Method.Put);

        var responseData = JsonSerializer.Deserialize<ApiResponseDTO>(response.Content);



        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        Assert.That(responseData.Msg, Is.EqualTo("Edited successfully"));

    }

    [Test, Order(4)]

    public void DeleteIdea_ShouldSucceed()
    {
        
        var request = new RestRequest($"/api/Idea/Delete");
        request.AddQueryParameter("IdeaId", lastIdeaID);
       

        var response = client.Execute(request, Method.Delete);

        


        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        Assert.That(response.Content, Does.Contain("The idea is deleted!"));

    }

    [Test, Order(5)]

    public void CreatNewIdea_WithoutCOrrectData_ShouldFail()
    {
        var requestData = new IdeaDTO()
        {
        
            Description = "TestDescription"
        };
        var request = new RestRequest("/api/Idea/Create");
        request.AddJsonBody(requestData);

        var response = client.Execute(request, Method.Post);

        var responseData = JsonSerializer.Deserialize<ApiResponseDTO>(response.Content);



        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));

    }

    [Test, Order(6)]

    public void EditIdea_WithoutCOrrectData_ShouldFail()
    {
        var requestData = new IdeaDTO()
        {
            Title = "EditedTitle",
            Description = "Edited TestDescription"
        };
        var request = new RestRequest($"/api/Idea/Edit");
        request.AddQueryParameter("IdeaId", "123");
        request.AddJsonBody(requestData);

        var response = client.Execute(request, Method.Put);

        


        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
        Assert.That(response.Content, Does.Contain("There is no such idea!"));
    }

    [Test, Order(7)]

    public void DeleteIdea_withBadRequest_ShouldFail()
    {

        var request = new RestRequest($"/api/Idea/Delete");
        request.AddQueryParameter("IdeaId", "112233");


        var response = client.Execute(request, Method.Delete);




        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
        Assert.That(response.Content, Does.Contain("There is no such idea!"));

    }
}
