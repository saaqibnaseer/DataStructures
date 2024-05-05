﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Abstract
{
    internal interface ILinkedList<T> : ICollection<T>
    {
        void AddToFront(T? item);
        void AddToEnd(T? item);
    }
}
