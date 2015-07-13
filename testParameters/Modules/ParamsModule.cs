/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 6/16/2015
 * Time: 12:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace testParameters.Modules
{
    using System;
    using System.Dynamic;
    using Nancy;
    using Nancy.ModelBinding;
    
    /// <summary>
    /// Description of ParamsModule.
    /// </summary>
    public class ParamsModule : NancyModule
    {
        public ParamsModule() : base("/test")
        {
            Post["/"] = parameters => {
                // wget.exe http://localhost:12340/test?a1=555 --post-data=a1=555 --post-data=a2=777
                var obj = this.Bind<Test>();
                Console.WriteLine(obj.a1);
                Console.WriteLine(obj.a2);
//                var dict = this.Bind<DynamicDictionary>();
//                Console.WriteLine(dict["a1"]);
//                Console.WriteLine(dict["a2"]);
                return "ready";
            };
            
            Post["/test2"] = parameters => {
                // wget.exe http://localhost:12340/test?a1=555 --post-data=a1=555 --post-data=a2=777
                // Console.WriteLine(parameters.a1);
                Console.WriteLine(parameters.aaa);
                return "ready";
            };
        }
    }
    
    public class Test
    {
        public string a1 { get; set; }
        public string a2 { get; set; }
    }
}
