/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 3/3/2015
 * Time: 12:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace DataExchangeService.Modules
{
	using System;
	using System.Diagnostics;
	using System.Threading;
	using DataExchangeInterfaces;
	using Nancy;
	using Nancy.ModelBinding;
	using DataExchangeService.ObjectModel;
	
	/// <summary>
	/// Description of TestModule.
	/// </summary>
	public class TestModule : NancyModule
	{
		public TestModule() : base("/aaa")
		{
			Post["/"] = data => {
				var someData = this.Bind<Something>();
				CommonData.SomeData = someData ?? new Something {
					StringData = "Fail!",
					IntData = 3
				};
				
				var processStartInfo = new ProcessStartInfo {
					// FileName = "calc.exe",
					FileName = @"..\..\..\DataExchangeTester\bin\Debug\DataExchangeTester.exe",
					UseShellExecute = true
				};
				Process.Start(processStartInfo);
				Thread.Sleep(3000);
				
				return Negotiate.WithStatusCode(HttpStatusCode.OK);
			};
			
			// Get["/"] = _ => CommonData.SomeData;
			// Get["/"] = _ => Negotiate.WithModel(CommonData.SomeData).WithStatusCode(HttpStatusCode.OK);
			Get["/"] = _ => null == CommonData.SomeData ?
				Negotiate.WithStatusCode(HttpStatusCode.NotFound) :
				Negotiate.WithMediaRangeModel("application/json", CommonData.SomeData).WithStatusCode(HttpStatusCode.OK);
		}
	}
}
