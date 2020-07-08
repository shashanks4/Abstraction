using System;

// namespace encapsulationdemo
// {
//     class Validation
//     {
//         private int x;
//         public int getX()
//         {
//             return x;
//         }
//         public void setX(int x)
//         {
//             if (x > 0)
//             {
//                 this.x = x;
//             }
//             else
//             {
//                 Console.WriteLine("Please Pass a positive value");
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
            
//             Validation validation = new Validation();
//          //  System.Console.WriteLine(validation.setX());
//            validation.setX(-10);
//            System.Console.WriteLine(validation.setX());
//         }
//     }
// }
 public class Validation
    {
        private int _x;
        public int getX()
        {
            return _x;
        }
        public void setX(int x)
        {
            if (_x > 0)
            {
                this._x = x;
            }
            else
            {
                Console.WriteLine("Please Pass a positive value");
            }
        }
    }
    class Sample
    {
        public static void Main()
        {
          Validation validation = new Validation();
            //We cannot use the variable directly here
            // e.x = 50; //Compile time errr
            // Console.WriteLine(e.x); //Compile time errr
            validation.setX(10);
            Console.WriteLine(validation.getX());
            validation.setX(-50);
            Console.WriteLine(validation.getX());
        }
    }