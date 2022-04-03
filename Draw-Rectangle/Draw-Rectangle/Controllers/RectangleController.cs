using Draw_Rectangle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Draw_Rectangle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RectangleController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var model = new RectangleProperties();
            model.LoadPropertiesValue();

            return new string[] { model.Length, model.Width };
        }


        [HttpPost]
        public void Post([FromBody] JsonElement rectData)
        {
            var rectangleValues = JsonConvert.DeserializeObject<RectangleProperties>(rectData.ToString());

            var model = new RectangleProperties();

            model.UpdateJsonFile(rectangleValues);
        }
    }
}
