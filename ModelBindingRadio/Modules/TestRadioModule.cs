/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 01/07/2015
 * Time: 10:11 p.m.
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
    /// Description of TestRadioModule.
    /// </summary>
    public class TestRadioModule : NancyModule
    {
        ModelImpl _model;
        
        public TestRadioModule() : base("/test")
        {
            Get["/"] = _ => {
                return View["Views/testView"];
            };
            
            Post["/"] = parameters => {
                _model = this.Bind<ModelImpl>();
                dynamic data = new ExpandoObject();
                data.Result = _model.Inputs001;
                return View["Views/result", data];
            };
        }
    }
}
