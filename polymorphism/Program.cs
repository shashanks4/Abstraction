// using System;
// namespace Polymorphism
// {
//  class Parent
//  {
//  public void Test() { Console.WriteLine("Parent::Test()"); }
//  }

//  class Child : Parent
//  {
//  public void Test() { Console.WriteLine("child::Test()"); }
//  }

//  class AnotherChild : Child
//  {
//  public void Test() { Console.WriteLine("C::Test()"); }
//  }

//  class Program
//  {
//  static void Main(string[] args)
//  {
 
//  Parent parent = new Parent();
//  Child child = new Child();
//  AnotherChild anotherChild = new AnotherChild();

//  parent.Test(); // output --> "A::Test()"
//  child.Test(); // output --> "B::Test()"
//  anotherChild.Test(); // output --> "C::Test()"

//  parent = new Child();
//  parent.Test(); // output --> "A::Test()"

//  child = new AnotherChild();
//  child.Test(); // output --> "B::Test()"

//  Console.ReadKey();
//  }
//  }
// }
using System;
namespace Polymorphism
{
    public class User
    {
        public void UserLogin(string username, string password)
        {
            if (username == "user" && password == "user@123")
            {
            
                Console.WriteLine("{0} is valid and Loged sucessfully.........", username);
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password!");
            }
        }

        public void UserLogin(string username, string password, string role)
        {
            if (role == "Admin" && (username == "admin" && password == "admin@123"))
            {
                Console.WriteLine("{0} is valid and Loged sucessfully.........", role);
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.UserLogin("user", "user@123");
            user.UserLogin("admin", "admin@123", "Admin");

            Console.ReadLine();
        }
    }
}
