using Groot;
using Groot.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

public class Test1
{
    private HttpClient Client;
    private TestServer Server;

    public Test1()
    {
        //arrange
        Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        Client = Server.CreateClient();
    }

    [Fact]
    public async Task IndexShouldReturnOkStatus()
    {
        //act
        var request = new HttpRequestMessage(HttpMethod.Get, "/groot");
        request.Headers.Add("message", "somemessage");
        var response = await Client.GetAsync("/groot");
        var responseJson = await response.Content.ReadAsStringAsync();

        //assert
        Assert.Equal("{\"received\": \"somemessage\",\"translated\": \"I am Groot!\"}", responseJson);
    }
}
