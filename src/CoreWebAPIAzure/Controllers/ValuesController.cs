using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CoreWebAPIAzure.Controllers;

[Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public ValuesController()
        {
            
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]{
                "Vivek","Bhardwaj"
            };
        }
        [HttpGet("{Id}")]
        public string Get(int id)
        {
            return "Vivek";
        }
        [HttpPost]
        public void Post([FromBody]string value)
        {
            
        }
        [HttpPut("{Id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        [HttpDelete("{Id}")]
        public void Delete(int id)
        {
        }
    }
