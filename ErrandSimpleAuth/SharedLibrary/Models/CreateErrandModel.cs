using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Models
{
    public class CreateErrandModel
    {        
        public string CustomerName { get; set; }
        
        public int ServiceWorkerId { get; set; }
        
        public DateTime Created { get; set; }       
                
        public string Description { get; set; }
        
        public string Status { get; set; }
    }
}
