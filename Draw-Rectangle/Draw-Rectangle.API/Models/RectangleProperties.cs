using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Draw_Rectangle.API.Models
{
    public class RectangleProperties
    {
        public string Length { get; set; }
        public string Width { get; set; }

       

        internal void LoadPropertiesValue()
        {
            var jsonFileInfo = Path.Combine(Directory.GetCurrentDirectory(), "RectangleValues.json");
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(jsonFileInfo));

            Length = jsonFile.Length;
            Width = jsonFile.Width;
        }

        internal void UpdateJsonFile(RectangleProperties rectangleValues)
        {
            string json = File.ReadAllText("RectangleValues.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            jsonObj["Length"] = rectangleValues.Length;
            jsonObj["Width"] = rectangleValues.Width;

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("RectangleValues.json", output);
        }
    }
}
