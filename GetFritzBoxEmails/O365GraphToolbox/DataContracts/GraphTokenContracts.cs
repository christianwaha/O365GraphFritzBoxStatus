using System.Runtime.Serialization;

namespace O365GraphToolbox.DataContracts
{
    [DataContract]
    public class GraphToken
    {
        [DataMember(Name = "token_type")]
        public string TokenType { get; set; }
        [DataMember(Name = "expires_in")]
        public string ExpiresIn { get; set; }
        [DataMember(Name = "ext_expires_in")]
        public string ExtExpiresIn { get; set; }
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }
    }
}
