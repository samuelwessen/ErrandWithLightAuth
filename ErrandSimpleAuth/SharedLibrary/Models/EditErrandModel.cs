using SharedLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Models
{
    public class EditErrandModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public int ServiceWorkerId { get; set; }

        public DateTime? Changed { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public virtual ServiceWorker ServiceWorker { get; set; }
    }
}
