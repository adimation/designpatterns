using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational.Singleton
{
    public class MultiSingleton
    {
        private static List<MultiSingleton> Instances { get; set; }
        public static int Limit { get; private set; }
        public int Id { get; set; }
        private static int Position { get; set; }

        private MultiSingleton()
        {
        }

        public static void SetLimit(int limit)
        {
            Instances = new List<MultiSingleton>();
            Limit = limit;
            Position = 0;

            for(int i = 0; i < Limit; i++)
            {
                Instances.Add(new MultiSingleton() { Id = i });
            }
        }

        public static MultiSingleton GetInstance()
        {
            MultiSingleton ret;

            if (Limit == 0) SetLimit(1);

            if (Position == Limit)
                Position = 0;

            ret = Instances[Position];

            Position++;

            return ret;
        }

    }
}
