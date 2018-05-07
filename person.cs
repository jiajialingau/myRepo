using System;


namespace people
{
    public class person
    {
        //person constructor
         string fname;
         string lname;       
         int age;
        public person()
        {
           fname="Michael";
           lname="LING";
           age=100;
            
        }

        //person display method
        public void welcome()
        {
            Console.WriteLine("hi, I am "+fname+" "+lname);
            Console.WriteLine("I am "+age+" years old");
        }

        public void eating()
        {
            Console.WriteLine(fname+" "+lname+" ok, I'm eating now......");
        }

        public void sleep()
        {
            Console.WriteLine(fname+" "+lname+" ok, I'm go to sleep, ZZZZ.........");
        }



        //main 
        

    }
}
