using System.Text.Json;
using MQTTnet;
using MQTTnet.Client.Options;
using robodoc.backend.MQTT.Models;

namespace robodoc.backend.MQTT
{
    public static class MqttPublish
    {
        public static async Task Publish_Application_Message()
        {
            /*
             * This sample pushes a simple application message including a topic and a payload.
             *
             * Always use builders where they exist. Builders (in this project) are designed to be
             * backward compatible. Creating an _MqttApplicationMessage_ via its constructor is also
             * supported but the class might change often in future releases where the builder does not
             * or at least provides backward compatibility where possible.
             */

            var mqttFactory = new MqttFactory();

            using (var mqttClient = mqttFactory.CreateMqttClient())
            {
                var mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer("broker.emqx.io")
                    .Build();

                await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                var applicationMessage = new MqttApplicationMessageBuilder()
                    .WithTopic("auftrag")
                    .WithPayload(JsonSerializer.Serialize<Auftrag>(new Auftrag()
                    {
                        MediRaum1 = 3,
                        MediRaum2 = 4,
                        MediRaum3 = 1,
                        MediRaum4 = 2
                    }))
                    .Build();

                await mqttClient.PublishAsync(applicationMessage, CancellationToken.None);
            }
        }
    }
}
