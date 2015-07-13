/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 01/07/2015
 * Time: 10:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ModelBindingRadio.Modules
{
    using System;
    using System.Dynamic;
    using Nancy;
    using Nancy.ModelBinding;
    
    /// <summary>
    /// Description of TestRadioWithoutTypeModule.
    /// </summary>
    public class TestRadioWithoutTypeModule : NancyModule
    {
        ModelImpl _model;
        
        public TestRadioWithoutTypeModule() : base("/test2")
        {
            Get["/"] = _ => {
                return View["Views/testView"];
            };
            
            Post["/"] = parameters => {
                dynamic data = new ExpandoObject();
                foreach (var element in parameters.Keys)
                    data.Result += element;
                return View["Views/result", data];
            };
        }
    }
}
