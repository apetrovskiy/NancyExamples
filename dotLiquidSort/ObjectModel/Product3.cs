/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/1/2014
 * Time: 3:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace NancyExamples
{
    using System;
    
    /// <summary>
    /// Description of Product3.
    /// </summary>
    public class Product3 : Product2
    {
        public Product3()
        {
            UniqueId = Guid.NewGuid();
        }
        
        public Guid UniqueId { get; set; }
    }
}