using System;


namespace people
{
    public class person
    {
        

        //person display method
        public void welcome(string fname, string lname, int age)
        {
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("hi, I am "+fname+" "+lname);
            Console.WriteLine("I am "+age+" years old");
        }

        public void eating(string fname, string lname)
        {
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine(fname+" "+lname+" ok, I'm eating now......");
        }

        public void sleep(string fname, string lname)
        {
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine(fname+" "+lname+" ok, I'm go to sleep, ZZZZ.........");
        }



        //main 
        

    }
}
