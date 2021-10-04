using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AuthSenderOptions
    {
        private readonly string user = "Food Delivery"; // The name you want to show up on your email
                                                        // Make sure the string passed in below matches your API Key
        private readonly string key = "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";
        public string SendGridUser { get { return user; } }
        public string SendGridKey { get { return key; } }

    }
}
