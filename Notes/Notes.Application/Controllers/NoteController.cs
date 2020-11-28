using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace Notes.Application.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NoteController : ControllerBase
	{
		// GET: api/<NoteController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<NoteController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<NoteController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<NoteController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<NoteController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
