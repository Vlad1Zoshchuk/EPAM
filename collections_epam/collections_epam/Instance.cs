using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace collections_epam
{
    class Instance<T> : IComparable<Instance<T>>
    {
        string name;
        List<T> instances;
        public Instance(string name)
        {
            this.name = name;
            instances = new List<T>();
        }

        ~Instance()
        {
            Console.WriteLine("DESTRUCTOR");
        }

        public static Instance<T> operator +(Instance<T> inst, T item)
        {
            inst.add(item);
            return inst;
        }

        public static Instance<T> operator -(Instance<T> inst, T item)
        {
            inst.remove(item);
            return inst;
        }

        public void add(T item)
        {
            instances.Add(item);
        }

        public void remove(T item)
        {
            instances.Remove(item);
        }

        public int size()
        {
            return instances.Count;
        }

        public int CompareTo(Instance<T> obj)
        {
            return Name.CompareTo(obj.Name);
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public T this[int index]
        {
            get
            {
                try
                {
                    return instances[index];
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR OCCUR {e.Message}");
                    return default(T);
                }
            }

            set
            {
                try
                {
                    instances[index] = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR OCCUR {e.Message}");
                }
            }
        }
    }

    class InstanceComparer<T> : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Instance<T> inst1 = x as Instance<T>;
            Instance<T> inst2 = y as Instance<T>;
            if (inst1.Name.Length > inst2.Name.Length) return 1;
            else if (inst1.Name.Length < inst2.Name.Length) return -1;
            else return 0;
        }
    }

}
