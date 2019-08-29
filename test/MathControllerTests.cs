using System;
using Xunit;
using server.Controllers;

namespace test {
	public class MathControllerTests {

		[Fact]
		public void TestHello() {
			var m = new MathController();
			var result = m.Hello();
			Assert.Equal("Hello World!", result.Value);
		}

		[Fact]
		public void TestAdd() {
			var m = new MathController();
			var result = m.Add(3, 2);
			Assert.Equal(5, result.Value);
		}

		[Fact]
		public void TestSub() {
			var m = new MathController();
			var result = m.Sub(3, 2);
			Assert.Equal(1, result.Value);
		}

		[Fact]
		public void TestMult() {
			var m = new MathController();
			var result = m.Mult(3, 2);
			Assert.Equal(6, result.Value);
		}

		[Fact]
		public void TestDiv() {
			var m = new MathController();
			var result = m.Div(3, 2);
			Assert.Equal(1.5, result.Value);
		}

		[Fact]
		public void TestDivZero() {
			var m = new MathController();
			var result = m.Div(3, 0);
			Assert.Equal("Infinity", result.Value.ToString());
		}

		[Fact]
		public void Sqrt() {
			var m = new MathController();
			var result = m.Sqrt(4);
			Assert.Equal(2, result.Value);
		}

		[Fact]
		public void Cbrt() {
			var m = new MathController();
			var result = m.Cbrt(27);
			Assert.Equal(3, result.Value);
		}

	}
}
