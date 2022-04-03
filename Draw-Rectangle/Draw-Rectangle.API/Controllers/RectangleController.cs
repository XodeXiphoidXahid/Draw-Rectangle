using Draw_Rectangle.API.Models;
using Google.Protobuf;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Draw_Rectangle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RectangleController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            var model = new RectangleProperties();
            model.LoadPropertiesValue();

            var recObj = new RectangleProperties()
            {
                Length = model.Length,
                Width = model.Width
            };

            return Ok(recObj);
            //return new string[] { model.Length, model.Width };
        }

        
        [HttpPost]
        public void Post([FromBody] JsonElement rectData)
        {
            var rectangleValues  = JsonConvert.DeserializeObject<RectangleProperties>(rectData.ToString());

            var model = new RectangleProperties();

            model.UpdateJsonFile(rectangleValues); 
        }

        
    }
}
