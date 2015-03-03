/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 3/3/2015
 * Time: 12:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace DataExchangeInterfaces
{
    using System;
    
    /// <summary>
    /// Description of ISomething.
    /// </summary>
    public interface ISomething
    {
        string StringData { get; set; }
        int IntData { get; set; }
        string Comment { get; set; }
    }
}
