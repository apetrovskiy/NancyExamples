/*
 * Created by SharpDevelop.
 * User: alexa_000
 * Date: 12/22/2014
 * Time: 2:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace tinyIocTest.Interfaces
{
    using System;
    
    /// <summary>
    /// Description of I01.
    /// </summary>
    public interface I01
    {
        void Test();
        bool IsTrue(bool value);
        string Name { get; set; }
    }
}
