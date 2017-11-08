using Grut;
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
        var response = await Client.GetAsync("/");

        //assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
