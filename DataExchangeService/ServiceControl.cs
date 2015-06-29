/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 03/03/2015
 * Time: 03:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace DataExchangeService
{
    using System;
    using System.ServiceProcess;
    
    /// <summary>
    /// Description of ServiceControl.
    /// </summary>
    public class ServiceControl : ServiceBase
    {
        public ServiceControl()
        {
        }
        
        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
        }
        
        protected override void OnStop()
        {
            base.OnStop();
        }
    }
}
