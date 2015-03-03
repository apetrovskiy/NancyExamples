/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/22/2014
 * Time: 2:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace tinyIocTest
{
    using System;
    using Nancy;
    using tinyIocTest.Interfaces;
    using tinyIocTest.ObjectModel;
    
    /// <summary>
    /// Description of StartUp.
    /// </summary>
    public class StartUp : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
Console.WriteLine("START UP 0001");
            base.ApplicationStartup(container, pipelines);
            
Console.WriteLine("START UP 0002");
container.Register<I01, Class01>().UsingConstructor<I01>(() => new Class01());
Console.WriteLine("START UP 0003");
            container.Register<Class02>();
Console.WriteLine("START UP 0004");
        }
    }
}
