/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 3/3/2015
 * Time: 12:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace DataExchangeService.ObjectModel
{
	using System;
	using DataExchangeInterfaces;
	
	/// <summary>
	/// Description of CommonData.
	/// </summary>
	public class CommonData
	{
		static Something _someData;
		public static Something SomeData
		{
			get { return _someData; }
			set { _someData = value; }
		}
	}
}
