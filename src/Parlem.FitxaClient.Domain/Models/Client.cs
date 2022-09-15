namespace Parlem.FitxaClient.Domain.Models
{
    public class Client 
    {
        public long Id { get; protected set; }
        public string DocType { get; protected set; }
        public string DocNum { get; protected set; }
        public string Email { get; protected set; }
        public long CustomerId { get; protected set; }
        public string GivenName { get; protected set; }
        public string FamilyName1 { get; protected set; }
        public long Phone { get; protected set; }

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