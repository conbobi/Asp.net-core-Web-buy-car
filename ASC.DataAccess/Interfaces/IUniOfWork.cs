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

namespace ASC.DataAccess.Interfaces
{
<<<<<<< HEAD
    public interface IUnitOfWork : IDisposable
=======
    public interface IUniOfWork : IDisposable
>>>>>>> e28523f (Lab 3)
    {
        IRepository<T> Repository<T>() where T : BaseEntity;
        public int CommitTransaction();
    }
}
