﻿/*
 * Created by SharpDevelop.
 * User: alexa_000
 * Date: 12/22/2014
 * Time: 2:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace tinyIocTest.Modules
{
    using System;
    using System.Dynamic;
    using Nancy;
    using Nancy.TinyIoc;
    using tinyIocTest.Interfaces;
    using tinyIocTest.ObjectModel;
    
    /// <summary>
    /// Description of TestModule.
    /// </summary>
    public class TestModule : NancyModule
    {
        public TestModule() : base("/test")
        {
            Get["/"] = _ => {
Console.WriteLine("001");
                dynamic expando = new ExpandoObject();
Console.WriteLine("002");
                expando.Test = "test";
Console.WriteLine("003");
                try {
Console.WriteLine("004");
                    expando.Test01 = TinyIoCContainer.Current.Resolve<I01>();
                    expando.Test01.Name = "via interface";
Console.WriteLine("005");
                }
                catch (Exception ee) {
                    Console.WriteLine(ee.Message);
                }
Console.WriteLine("006");
                expando.Test02 = TinyIoCContainer.Current.Resolve<Class02>();
                expando.Test02.Name = "via class (the only option)";
Console.WriteLine("007");
                expando.Test03 = TinyIoCContainer.Current.Resolve<Class01>();
                expando.Test03.Name = "via class";
Console.WriteLine("008");
                return View["Test", expando];
            };
        }
    }
}
