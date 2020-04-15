using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational.Singleton
{
    public class MultithreadSafeSingleton
    {
        private static MultithreadSafeSingleton Instance { get; set; }
        private static object Obj = new Object();

        private MultithreadSafeSingleton()
        {
        }

        public static MultithreadSafeSingleton GetInstance()
        {
            if (Instance == null)
            {
                lock(Obj)
                {
                    if (Instance == null)
                    {
                        Instance = new MultithreadSafeSingleton();
                    }
                }
            }

            return Instance;
        }
    }
}
