/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 26/06/2015
 * Time: 04:27 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ModelBindingSimple.Modules
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;
    using ModelBindingSimple.ObjectModel;
    
    /// <summary>
    /// Description of TestModule.
    /// </summary>
    public class TestModule : NancyModule
    {
        public TestModule() : base("/")
        {
            Post["test/"] = _ => {
                var testResult = this.Bind<TestClass>(new BindingConfig { IgnoreErrors = true });
                return Negotiate.WithView("testView.htm").WithStatusCode(HttpStatusCode.Created).WithModel(testResult);
            };
            
            Get["test/"] = _ => View["Views/testView.htm"];
        }
    }
}
