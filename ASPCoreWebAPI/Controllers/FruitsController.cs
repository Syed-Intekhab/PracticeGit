using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        public static readonly List<string> fruits = new()
        {
            "Apple",
            "Banana",
            "Orange",
            "Mango",
            "Grapes"
        };

        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }

        [HttpGet("{id}")]
        public string GetFruits(int id)
        {
            try
            {
                return fruits.ElementAt(id);
            } catch (Exception)
            {
                return "Fruit not found!";
            }
        }

        [HttpPost("{fruit}")]
        public string AddFruits(string fruit)
        {
            if (!string.IsNullOrEmpty(fruit))
            {
                fruits.Add(fruit);
                return "Fruit Added Successfully!";
            }

            return "Something Went Wrong!";
        }
    }
}
