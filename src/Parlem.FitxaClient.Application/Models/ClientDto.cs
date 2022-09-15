using System.Numerics;

namespace Parlem.FitxaClient.Application.Models
{
    public class ClientDto
    {
        public long Id { get; private set; }
        public string DocType { get; private set; }
        public string DocNum { get; private set; }
        public string Email { get; private set; }
        public long CustomerId { get; private set; }
        public string GivenName { get; private set; }
        public string FamilyName1 { get; private set; }
        public long Phone { get; private set; }

        public ClientDto(long id, string docType, string docNum, string email, long customerId, string givenName, string familyName1, long phone)
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