using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational.Singleton
{
    public class SimpleSingleton
    {
        private static SimpleSingleton Instance { get; set; }

        private SimpleSingleton()
        {
        }

        public static SimpleSingleton GetInstance()
        {
            if(Instance == null)
            {
                Instance = new SimpleSingleton();
            }

            return Instance;
        }
    }
}
