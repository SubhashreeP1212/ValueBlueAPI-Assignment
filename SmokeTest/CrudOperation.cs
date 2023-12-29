using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueBlueAPI.Model;

namespace ValueBlueAPI.SmokeTest
{
    [TestClass]
    public class CrudOperation
    { 

        [TestMethod]
        public void VerifyGetResponse()
        {
            var helper = new Helper<ListOfUsers>();
            var response = helper.CreateGetRequest("api/users?page=2");
            ListOfUsers content = helper.GetContent<ListOfUsers>(response);
            helper.HttpsStatusCode(response);
            Assert.AreEqual(2, content.Page);
            Assert.AreEqual(7, content.Data[0].Id);
            
        }
        [TestMethod]
        public void CreateNewUser()
        {
            string payload = @"{
                            ""name"": ""Subha"",
                             ""job"": ""QA""}";
            var helper = new Helper<ListOfCreateUsers>();
            var response = helper.CreatePostRequest("api/users", payload);
            helper.HttpsStatusCode(response);
            ListOfCreateUsers content = helper.GetContent<ListOfCreateUsers>(response);            
            Assert.AreEqual("Subha", content.Name); 
            
        }

        [TestMethod]
        public void UpdateUser()
        {
            string payload = @"{
                             ""name"": ""Subhashree"",
                             ""job"": ""zion resident""}";
            var helper = new Helper<ListOfUpdateUsers>();
            var resposne = helper.CreatePutRequest("api/users/2" , payload);
            helper.HttpsStatusCode(resposne);
            ListOfUpdateUsers content = helper.GetContent<ListOfUpdateUsers>(resposne);
            Assert.AreEqual("Subhashree", content.Name);            
        }

        [TestMethod]
        public void DeleteUser()
        {
            var helper = new Helper<ListOfUpdateUsers>();
            var response = helper.CreateDeleteRequest("api/users/2");
            helper.HttpsStatusCode(response);
        }
        
    }
}
