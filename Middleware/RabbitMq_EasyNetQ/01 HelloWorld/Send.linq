<Query Kind="Statements">
  <NuGetReference>EasyNetQ</NuGetReference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>EasyNetQ</Namespace>
</Query>


using (var bus = RabbitHutch.CreateBus("host=localhost"))
{
	var message = "Hello World!";
	bus.PubSub.Publish(new TextMessage { Text = message });
	Console.WriteLine(" [x] Sent {0}", message);
}

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();


[Queue("hello", ExchangeName = "")]
public class TextMessage
{
	public string Text { get; set; }
}
