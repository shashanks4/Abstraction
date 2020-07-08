using System;

namespace Osinheritance
{
      public class Unix
    {
     public void OperatingSystem()
     {
         System.Console.WriteLine("  i use kernel ");
     } 
     public virtual void GUI()
     {
         System.Console.WriteLine("Unix was initially a command based OS. Most of the unix distributions now have Gnome");
     }
     public virtual void Shell()
     {
         System.Console.WriteLine("Bourne Shell for Unix");
     }
    
    }
     public class Linux : Unix
    {
        public new  void GUI()
        {
            System.Console.WriteLine("Linux uses KDE and Gnome. Other GUI supported are LXDE, Xfce, Unity, Mate.");
        }
    
        public override void Shell()
        {
            System.Console.WriteLine("Bash shell which is internally based on bourne Sh shell of Unix");
        }
    }
     public class Android : Linux
    {
        public void AndroidOperatingSystem()
        {
            System.Console.WriteLine(" Im the framework built on top of Linux kernel");
        }
        public void Applications()
        {
            System.Console.WriteLine("Majorly used for Mobile and Smart Tvs");
        }
    }
  public  class Program
    {
     public static void Main(string[] args)
        {
           Android android = new Android();
           android.Applications();
     Unix linux = new Android();
        linux.Shell();
        Unix unix = new Unix();
          unix.Shell();
         
        }
    }
}
