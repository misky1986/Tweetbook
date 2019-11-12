using System.Collections.Generic;

namespace Tweetbook.Domain
{
    public class AuthenticationResult
    {
        public string Token { get; set; }
        public bool Succcess { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
