using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FC.BlazorCharts.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FC.BlazorCharts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<ChartsData> data = GetChartsData();

            return Ok(data);
        }

        //Fake Data
        private List<ChartsData> GetChartsData()
        {
            var myData = new List<ChartsData>();

            for (int i = 0; i < 48; i++)
            {
                var doubleData = new double[] { 
                    new Random().Next(6590, 6625), 
                    new Random().Next(6590, 6625), 
                    new Random().Next(6590, 6625), 
                    new Random().Next(6590, 6625) 
                };

                myData.Add(new ChartsData()
                {
                    X = new DateTimeOffset(DateTime.UtcNow.AddHours(i)).ToUnixTimeMilliseconds(),
                    Y = doubleData
                });
            }

            return myData;
        }
    }
}