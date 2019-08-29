using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using Xunit;

namespace integration {

    public class MathController {

        readonly string url;
		readonly HttpClientHandler handler;
		readonly HttpClient httpClient;

		Task<String> response;

		public MathController() {
			handler = new HttpClientHandler();
			httpClient = new HttpClient(handler);
			url = GetTestURL();
		}

		~MathController() {
			httpClient.Dispose();
		}

		private string GetTestURL() {
			string ipAddress = "localhost",
				port = "8080";

			if (Dns.GetHostAddresses(Dns.GetHostName()).Length > 0) {
				ipAddress = Dns.GetHostAddresses(Dns.GetHostName()).Where(ip => !System.Net.IPAddress.IsLoopback(ip) && ip.AddressFamily.Equals(AddressFamily.InterNetwork)).ToArray().GetValue(0).ToString();
			}

			return "http://" + ipAddress + ":" + port;
		}

        [Fact]
        public void TestHello() {
			response = httpClient.GetStringAsync(url);
			Assert.Equal("Hello World!", response.Result);
			Assert.True(response.IsCompletedSuccessfully);
		}

		[Fact]
        public void TestAdd() {
			response = httpClient.GetStringAsync(url+"/add/3/2");
			Assert.Equal("5.0", response.Result);
			Assert.True(response.IsCompletedSuccessfully);
		}

		[Fact]
        public void TestSub() {
			response = httpClient.GetStringAsync(url+"/sub/3/2");
			Assert.Equal("1.0", response.Result);
			Assert.True(response.IsCompletedSuccessfully);
		}

		[Fact]
        public void TestMult() {
			response = httpClient.GetStringAsync(url+"/mult/3/2");
			Assert.Equal("6.0", response.Result);
			Assert.True(response.IsCompletedSuccessfully);
		}

		[Fact]
        public void TestDiv() {
			response = httpClient.GetStringAsync(url+"/div/3/2");
			Assert.Equal("1.5", response.Result);
			Assert.True(response.IsCompletedSuccessfully);
		}

		[Fact]
        public void TestDivZero() {
			response = httpClient.GetStringAsync(url+"/div/3/0");
			Assert.Equal("\"Infinity\"", response.Result);
			Assert.True(response.IsCompletedSuccessfully);
		}

		[Fact]
        public void TestSqrt() {
			response = httpClient.GetStringAsync(url+"/sqrt/4");
			Assert.Equal("2.0", response.Result);
			Assert.True(response.IsCompletedSuccessfully);
		}

		[Fact]
        public void TestCbrt() {
			response = httpClient.GetStringAsync(url+"/cbrt/27");
			Assert.Equal("3.0", response.Result);
			Assert.True(response.IsCompletedSuccessfully);
		}

	}
}
