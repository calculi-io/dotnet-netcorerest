using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers {

	[Route("/")]
	[ApiController]
	public class MathController : ControllerBase {
		
		[HttpGet]
		public ActionResult<string> Hello() {
			return "Hello World!";
		}

		[HttpGet("add/{a}/{b}")]
		public ActionResult<Double> Add(Double a, Double b) {
			return a + b;
		}

		[HttpGet("sub/{a}/{b}")]
		public ActionResult<Double> Sub(Double a, Double b) {
			return a - b;
		}

		[HttpGet("mult/{a}/{b}")]
		public ActionResult<Double> Mult(Double a, Double b) {
			return a * b;
		}

		[HttpGet("div/{a}/{b}")]
		public ActionResult<Double> Div(Double a, Double b) {
			return a / b;
		}

		[HttpGet("sqrt/{a}")]
		public ActionResult<Double> Sqrt(Double a) {
			return Math.Sqrt(a);
		}

		[HttpGet("cbrt/{a}")]
		public ActionResult<Double> Cbrt(Double a) {
			return Math.Cbrt(a);
		}

	}
}
