using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Push
{
    public class Program {
        public static void Main(string[] args) {
            //Mess a = new Mess();
            //a.message = "Сообщение";
            //a.Send();
            var host = CreateWebHostBuilder(args).Build();
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>(); 
    
  
    class Mess
    {
            public Mess()
            {

            }
            public string message { get; set; }
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
        

}
