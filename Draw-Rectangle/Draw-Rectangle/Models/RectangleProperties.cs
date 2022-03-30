using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Draw_Rectangle.Models
{
    public class RectangleProperties
    {
        public string Length { get; set; }
        public string Width { get; set; }

        public RectangleProperties()
        {

        }

        internal void LoadPropertiesValue()
        {
            var jsonFileInfo = Path.Combine(Directory.GetCurrentDirectory(), "RectangleValues.json");
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(jsonFileInfo));

            Length = jsonFile.Length;
            Width = jsonFile.Width;
        }
    }
}
