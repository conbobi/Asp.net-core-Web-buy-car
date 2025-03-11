<<<<<<< HEAD
﻿using ASC.Model.Basetypes;
=======
﻿using ASC.Model.BaseTypes;
>>>>>>> e28523f (Lab 3)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC.Model.Models
{
    public class ServiceRequest : BaseEntity, IAuditTracker
    {
        public ServiceRequest() { }
<<<<<<< HEAD

        public ServiceRequest(string email)
=======
        public ServiceRequest(string email) 
>>>>>>> e28523f (Lab 3)
        {
            this.RowKey = Guid.NewGuid().ToString();
            this.PartitionKey = email;
        }
<<<<<<< HEAD

=======
>>>>>>> e28523f (Lab 3)
        public string VehicleName { get; set; }
        public string VehicleType { get; set; }
        public string Status { get; set; }
        public string RequestedServices { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string ServiceEngineer { get; set; }
    }
}
