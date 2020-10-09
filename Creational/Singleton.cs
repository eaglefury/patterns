using System.Collections.Generic;

namespace Patterns.Creational
{
    public class GlobalObject
    {
        private static GlobalObject instance;

        private GlobalObject()
        {
            myGlobalList = new List<string>();
        }

        public static GlobalObject GetInstance()
        {
            object lockObject = new object();

            lock (lockObject) // making it thread safe. Can also be done by making instance volatile and 
                              // doing double check locking
            {
                if (instance == null)
                {
                    instance = new GlobalObject();
                }
            }
            return instance;
        }

        public List<string> myGlobalList;
    }
}