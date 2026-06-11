using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;



namespace LibraryManagementSystem
{
    internal class aiservies
    {
    
        private string apiKey = ConfigurationManager.AppSettings["ApiKey"];
        private string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
        private string model = ConfigurationManager.AppSettings["Model"];
        public async Task<string> GetAIResponse(string userMessage)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                return "API Key missing!\nAdd ApiKey in App.config";

            if (string.IsNullOrWhiteSpace(apiUrl))
                return "API URL missing!\nAdd ApiUrl in App.config";

            if (string.IsNullOrWhiteSpace(model))
                return "Model missing!\nAdd Model in App.config";


            try
            {

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", apiKey);

                    // Request object
                    AIRequest requestObj = new AIRequest
                    {
                        model = model,
                        messages = new Message[]
                        {
                            new Message { role = "system", content = "You are a library assistant." },
                            new Message { role = "user", content = userMessage }
                        }
                    };


                    // Convert object → JSON
                    var serializer = new DataContractJsonSerializer(typeof(AIRequest));
                    MemoryStream ms = new MemoryStream();
                    serializer.WriteObject(ms, requestObj);
                    ms.Position = 0;

                    var content = new StreamContent(ms);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // API call
                    var response = await client.PostAsync(apiUrl, content);


                    string json = await response.Content.ReadAsStringAsync();

                    // Extract AI reply
                    return ExtractContent(json);
                }
            


            }
            catch (Exception e)
            {

                        return "Error : " + e.Message;

            }
        }

        // Simple JSON parser
        private string ExtractContent(string json)
        {
            try
            {
                int start = json.IndexOf("\"content\":\"") + 11;
                int end = json.IndexOf("\"", start);

                return json.Substring(start, end - start)
                           .Replace("\\n", "\n");
            }
            catch
            {
                return "AI response error.";
            }
        }
    }

    //  Models
    [DataContract]
    public class AIRequest
    {
        [DataMember]
        public string model { get; set; }

        [DataMember]
        public Message[] messages { get; set; }
    }

    [DataContract]
    public class Message
    {
        [DataMember]
        public string role { get; set; }

        [DataMember]
        public string content { get; set; }
    }

}

