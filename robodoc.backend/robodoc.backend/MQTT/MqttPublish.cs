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
            var mqttFactory = new MqttFactory();

            using (var mqttClient = mqttFactory.CreateMqttClient())
            {
                var mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer("broker.emqx.io")
                    .Build();

                await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                var applicationMessage = new MqttApplicationMessageBuilder()
                    .WithTopic("auftrag")
                    .WithPayload(JsonSerializer.Serialize(new Auftrag()
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
