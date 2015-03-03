/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 3/3/2015
 * Time: 1:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace DataExchangeTester
{
	using System;
	using DataExchangeInterfaces;
	using Spring.Http.Converters.Json;
	using Spring.Rest.Client;
	
	class Program
	{
		public static void Main(string[] args)
		{
			var restTemplate = new RestTemplate("http://localhost:12340");
			restTemplate.MessageConverters.Add(new JsonHttpMessageConverter());
			var data = restTemplate.GetForMessage<Something>("/aaa");
			Console.WriteLine("is data received null? {0}", null == data);
			Console.WriteLine(data.Body.StringData);
			Console.WriteLine(data.Body.IntData);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}