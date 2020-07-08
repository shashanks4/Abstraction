using System;

namespace Abstraction
{
   
    public class Car
    {
        private string _CarName = "Honda City";
        private string _CarColur = "Black";
        public string CarName
        {
            set
            {
                _CarName = value;
            }
            get
            {
                return _CarName;
            }
        }
        public string CarColur
        {
            set
            {
                _CarColur = value;
            }
            get
            {
                return _CarColur;
            }
        }
        public void Steering()
        {
            Console.WriteLine("Streering of the Car");
        }
        
        public void Brakes()
        {
            Console.WriteLine("Brakes of the Car");
        }
        public void Gear()
        {
            Console.WriteLine("Gear of the Car");
        }
        private void CarEngine()
        {
            Console.WriteLine("Engine of the Car");
        }
        private void DiesalEngine()
        {
            Console.WriteLine("DiesalEngine of the Car");
        }
        
        private void Silencer()
        {
            Console.WriteLine("Silencer of the Car");
        }
    }
   public  class Program
{
    public static void Main()
    {
        //Creating an instance of Car
        Car carObject = new Car();
        //Accessing the Public Properties and methods
        string CarName = carObject.CarName;
        string CarColur = carObject.CarColur;
        carObject.Brakes();
        carObject.Gear();
        carObject.Steering();
        //Try to access the private variables and methods
        //Compiler Error, 'Car._CarName' is inaccessible due to its protection level
    //    carObject._CarName;
        //Compiler Error, 'Car.CarEngine' is inaccessible due to its protection level
    //    carObject.CarEngine();
      //  carObject.Silencer();
    }
}
}


