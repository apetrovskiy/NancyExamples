/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/4/2014
 * Time: 4:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace NancyExamples.Helpers
{
    using System;
    using Nancy;
    using Nancy.Bootstrapper;
    
    /// <summary>
    /// Description of ApplicationStartup.
    /// </summary>
    public class ApplicationStartup : IApplicationStartup
    {
        #region IApplicationStartup implementation
        void IApplicationStartup.Initialize(IPipelines pipelines)
        {
            // pipelines.AfterRequest += (ctx) => Console.WriteLine(ctx.CurrentUser.UserName);
            
            // pipelines.BeforeRequest += (ctx) => Console.WriteLine(ctx.CurrentUser.UserName);
            
//            pipelines.BeforeRequest += (ctx) => {
//Console.WriteLine(ctx.CurrentUser.UserName);
//                return ctx.Response;
//            };
        }
        #endregion
//        private IFooFactory fooFactory;
//        public FooBeforeAllRequests(IFooFactory fooFactory) {
//            this.fooFactory = fooFactory;
//        }
//        
//        public void Initialize(IPipelines pipelines) {
//            pipelines.BeforeRequest.AddItemToStartOfPipeline(ctx => {
//                var foo = fooFactory.Make();
//                foo.Bar(ctx);
//            });
//        }
        
        
    }
}
