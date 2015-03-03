/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/22/2014
 * Time: 2:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace tinyIocTest.ObjectModel
{
    using System;
    using tinyIocTest.Interfaces;
    
    /// <summary>
    /// Description of Class01.
    /// </summary>
    public class Class01 : I01
    {
        public void Test()
        {
            // 
        }
        public bool IsTrue(bool value)
        {
            return value;
        }
        public string Name { get; set; }
    }
}
