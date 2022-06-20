﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDB<T, K>
    {
        void Create(T item);

        T Read(K key, bool takeNavigationProperties = false);

        IEnumerable<T> ReadAll(bool takeNavigationProperties = false);

        void Update(T item);

        void Delete(K key);
    }
}
