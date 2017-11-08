using Exercise_01_Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Frontend.Test
{
    public class Fronted_test1
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public Fronted_test1()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task Ok()
        {
            //act
            var response = await Client.GetAsync("/dountil/sum");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
