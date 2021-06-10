using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiActionWithAxios.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        [Route("TestUsingStreamReader")]
        public async Task<string> TestUsingStreamReader()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var content =  await reader.ReadToEndAsync();
                return content;
            }
        }

        [HttpPost]
        [Route("TestUsingFromBodyAttribute")]
        public object TestUsingFromBodyAttribute([FromBody] System.Text.Json.JsonElement content)
        {
            return content;
        }

        [HttpPost]
        [Route("TestUsingFromBodyAttributeStringType")]
        public async Task<string> TestUsingFromBodyAttributeStringType([FromBody] string content)
        {
            return content;
        }

        [HttpPost]
        [Route("JsonContentFromBodyAutoConvert")]
        public string JsonContentFromBodyAutoConvert([FromBody] object content)
        {
            return content.GetType().FullName;
        }
    }
}
