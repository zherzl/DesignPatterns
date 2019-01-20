﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class IdentityMap<T>
    {
        Hashtable entities = new Hashtable();
        public T GetById(Guid Id)
        {
            if (entities.ContainsKey(Id))
                return (T)entities[Id];
            else
                return default(T);
        }
        public void Store(T entity, Guid key)
        {
            if (!entities.Contains(key))
                entities.Add(key, entity);
        }

    }
}
