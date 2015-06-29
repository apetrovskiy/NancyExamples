/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 26/06/2015
 * Time: 04:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ModelBindingSimple.ObjectModel
{
    using System;
    
    /// <summary>
    /// Description of TestClass.
    /// </summary>
    public class TestClass
    {
        public bool BoolProperty { get; set; }
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }
        public string Under_score { get; set; }
        public string NoDashes { get; set; }
        public string NoSpaces01 { get; set; }
        public string NoSpaces02 { get; set; }
        public string @WithКириллица01 { get; set; }
    }
}
