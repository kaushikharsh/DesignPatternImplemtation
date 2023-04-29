using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAndRegistry
{
    class StudentRegistry
    {
        private static StudentRegistry _instance;
        private static readonly object _lock = new object();
        private StudentRegistry()
        {
                
        }
        public static StudentRegistry getinstance()
        {
            if(_instance == null)
            {
                //Apply DCL Double Checking Lock for MultiThreaded Environment
                lock(_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new StudentRegistry();
                    }
                }
                
            }
            return _instance;
        }
        Dictionary<string, Student> map = new Dictionary<string, Student>();

        public void Regsiter(string key, Student student)
        {
            map.Add(key, student);
        }
        public Student get(string key)
        {
            return map[key];
        }
    }
}
