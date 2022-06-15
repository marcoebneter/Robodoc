using System.Reflection.Metadata.Ecma335;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;

namespace robodoc.backend.MQTT
{
    public static class Mqtt
    {
        private const string connectionString = "broker.mqttdashboard.com:8000";

        public static async Task Handle_Received_Application_Message()
        {
            var mqttFactory = new MqttFactory();
            using (var mqttClient = mqttFactory.CreateMqttClient())
            {
                var mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer(connectionString)
                    .Build();
                mqttClient.ApplicationMessageReceivedHandler.HandleApplicationMessageReceivedAsync(null);
                await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
                var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                    .WithTopicFilter(f => { f.WithTopic("statusRobo"); })
                    .Build();
                await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);
            }
        }

        public static async Task Subscribe_Topic()
        {
            var mqttFactory = new MqttFactory();
            using (var mqttClient = mqttFactory.CreateMqttClient())
            {
                var mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer("broker.hivemq.com")
                    .Build();
                await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
                var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                    .WithTopicFilter(f => { f.WithTopic("mqttnet/samples/topic/1"); })
                    .Build();
                var response = await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);
                Console.WriteLine("MQTT client subscribed to topic.");
            }
        }
    }
}
