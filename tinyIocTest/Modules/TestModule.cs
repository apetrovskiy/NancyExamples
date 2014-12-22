/*
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
                expando.Test01 = TinyIoCContainer.Current.Resolve<I01>();
                expando.Test02 = TinyIoCContainer.Current.Resolve<Class02>();
                expando.Test03 = TinyIoCContainer.Current.Resolve<Class01>();
                return View["Test", expando];
            };
        }
    }
}
