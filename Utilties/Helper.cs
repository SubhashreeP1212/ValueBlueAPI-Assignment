using RestSharp;
using System;
using Newtonsoft.Json;


namespace ValueBlueAPI
{
    public class Helper<T>
    {
        private String baseURL = "https://reqres.in/";
        private String getURL = "https://reqres.in/api/users?page=2";
        private String postURL = "https://reqres.in/api/users";
        private RestClient restClient;
        private RestRequest restRequest;
        private RestResponse response;

        
        public RestResponse CreatePostRequest(String endpoint,String payload)
        {
            restClient = new RestClient(baseURL);
            restRequest = new RestRequest(endpoint,Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            response = restClient.Execute(restRequest);
            return response;

        }
        public RestResponse CreateGetRequest(String endpoint)
        {
            restClient = new RestClient(baseURL);
            restRequest = new RestRequest(endpoint, Method.Get);
            restRequest.AddHeader ("Accept", "application/json");
            return restClient.Execute(restRequest);
        }
        public RestResponse CreatePutRequest(String endpoint, String payload)
        {
            restClient = new RestClient(baseURL);
            restRequest = new RestRequest(endpoint, Method.Put);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            response = restClient.Execute(restRequest);
            return response;
        }
        public RestResponse CreateDeleteRequest(String endpoint)
        {
            restClient = new RestClient(baseURL);
            restRequest = new RestRequest(endpoint, Method.Delete);
            restRequest.AddHeader("Accept", "application/json");
            return restClient.Execute(restRequest);
        }

        public DTO GetContent<DTO>(RestResponse response)
        {
            var content = response.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }
        public void HttpsStatusCode(RestResponse response)
        {
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.IsSuccessStatusCode);
        }
    }
}
