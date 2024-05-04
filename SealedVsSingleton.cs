using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    internal class SealedVsSingleton
    {
    }

    sealed class Vehicle
    {
        //class implementation
    }

    //Vehicle is sealed class so this cannot be inherited else it will
    //throw compilation error
    //class Car : Vehicle
    //{

    //}


    //databaseconnection class follows the singleton pattern
    class DatabaseConnection
    {
        private static DatabaseConnection instance;

        private DatabaseConnection()
        {
            //private constructor to prevent external instantiation
        }

        public static DatabaseConnection GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DatabaseConnection();
                return instance;
            }
        }

        //other methods and properties
    }
}
