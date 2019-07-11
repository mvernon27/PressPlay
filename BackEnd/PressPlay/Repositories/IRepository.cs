﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressPlay.Repositories
{
    public interface IRepository<T> where T: class

    {
        IEnumerable<T> GetAll();
    }
}
