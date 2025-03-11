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
    public class MasterDataValue : BaseEntity, IAuditTracker
    {
        public MasterDataValue() { }
<<<<<<< HEAD

        public MasterDataValue(string masterDataPartitionKey, string value)
=======
        public MasterDataValue(string masterDataPartitionKey, string value) 
>>>>>>> e28523f (Lab 3)
        {
            this.PartitionKey = masterDataPartitionKey;
            this.RowKey = Guid.NewGuid().ToString();
        }
<<<<<<< HEAD

=======
>>>>>>> e28523f (Lab 3)
        public bool IsActive { get; set; }
        public string Name { get; set; }
    }
}
