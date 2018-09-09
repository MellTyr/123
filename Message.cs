using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Push
{
    public class Message
    {
        public Message()
        {

        }
        public string message { get; set; }
     //   public string message = "QWe";
        public void Send()
        {

            var parameters = new NameValueCollection {
    { "token", "afv93xahnzkc5j3m7arz4t8remheg7" },
    { "user", "u7u5oyf3fivghery8a854791ow37wq" },
    { "message", message }
};

            using (var client = new WebClient())
            {
                client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
            }

        }
    }
}
