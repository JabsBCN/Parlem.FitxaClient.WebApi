using System.Text.Json.Serialization;

namespace Parlem.FitxaClient.Domain.Models
{
    public class Client
    {
        [JsonPropertyName("_id")]
        public long Id { get; protected set; }
        [JsonPropertyName("docType")]
        public string DocType { get; protected set; }
        [JsonPropertyName("docNum")]
        public string DocNum { get; protected set; }
        [JsonPropertyName("email")]
        public string Email { get; protected set; }
        [JsonPropertyName("customerId")]
        public long CustomerId { get; protected set; }
        [JsonPropertyName("givenName")]
        public string GivenName { get; protected set; }
        [JsonPropertyName("familyName1")]
        public string FamilyName1 { get; protected set; }
        [JsonPropertyName("phone")]
        public long Phone { get; protected set; }

        public Client()
        {
        }

        internal Client(long id, string docType, string docNum, string email, long customerId, string givenName, string familyName1, long phone)
        {
            Id = id;
            DocType = docType;
            DocNum = docNum;
            Email = email;
            CustomerId = customerId;
            GivenName = givenName;
            FamilyName1 = familyName1;
            Phone = phone;
        }
    }
}