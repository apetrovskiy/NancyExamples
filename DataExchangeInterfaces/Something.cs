/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 3/3/2015
 * Time: 12:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace DataExchangeInterfaces
{
    using System;
    
    /// <summary>
    /// Description of Something.
    /// </summary>
    public class Something : ISomething
    {
        public string StringData { get; set; }
        public int IntData { get; set; }
        public string Comment { get; set; }
    }
}
