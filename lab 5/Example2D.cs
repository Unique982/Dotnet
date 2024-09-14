using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab5.MultipleInheritanceInterface;

namespace lab5
{
    public class MultipleInheritanceInterface
    { 
       

        public interface ILoadable
        {
            void Load();
        }

        public interface ITransportable
        {
            void Transport();
        }
        public interface IUnloadable
        {
            void Unload();
        }

        public class Truck :  ILoadable, ITransportable, IUnloadable
        {
           

            public void Load()
            {
                Console.WriteLine("The truck loads.");
            }
            public void Transport()
            {
                Console.WriteLine("The truck transports.");
            }
            public void Unload()
            {
                Console.WriteLine("The truck unloads.");
            }
        }

        public static void Main(string[] args)
        {
            Truck myTruck = new Truck();
       
            myTruck.Load();
            myTruck.Transport();
            myTruck.Unload();
            Console.ReadKey();
        }
    }

    public class Tipper :  ILoadable ,ITransportable, IUnloadable
    {
       
        public void Load()
        {
            Console.WriteLine("The tipper loads.");
        }
        public void Transport()
        {
            Console.WriteLine("The tipper transports.");
        }

        public void Unload()
        {
            Console.WriteLine("The tipper unloads.");
            Console.ReadKey();
        }
    }

    public class Worker
    {
        public void Work()
        {
            Console.WriteLine("The worker is working.");
        }
    }

    public class Manager : Worker
    {
        public void Manage()
        {
            Console.WriteLine("The manager is managing.");
        }
    }

    public class Boss : Manager
    {
        public void BossTask()
        {
            Console.WriteLine("The boss is completing the task.");
        }
    }

    public class Example2D
    {
        public static void Main(string[] args)
        {
            Boss myBoss = new Boss();
            myBoss.Work();
            myBoss.Manage();
            myBoss.BossTask();
            Console.ReadKey();
        }
    }
}
