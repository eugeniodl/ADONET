﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
