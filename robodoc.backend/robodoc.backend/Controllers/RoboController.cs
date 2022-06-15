using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace robodoc.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] string value)
        {
            switch (value)
            {
                case "startRobo":
                {
                    MQTT.MqttPublish.Publish_Application_Message();
                    break;
                }
            }
        }
    }
}
