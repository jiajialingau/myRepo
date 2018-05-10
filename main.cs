

using System;
using people;

public class run {

    public static void Main(string[] args)
        {

            string usrFname;
            string usrLname;
            int age;

            Console.Clear();
            
            Console.WriteLine("please input your first name: ");
            usrFname=Console.ReadLine();

            Console.WriteLine("Please input your last name: ");
            usrLname=Console.ReadLine();

            Console.WriteLine("please input your age: ");
            age=Convert.ToInt32(Console.ReadLine());


            person a = new people.person();
            a.welcome(usrFname,usrLname,age);
            a.eating(usrFname,usrLname);
            a.sleep(usrFname,usrLname);



         

        }




}