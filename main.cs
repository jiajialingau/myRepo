


using System;
using people;

public class run {

    public static void Main(string[] args)
        {

            person a = new people.person();
            a.welcome();
            a.eating();
            a.sleep();

           int num;
           Console.WriteLine("please input your number: ");
           num=Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("you entered "+num);

         

        }




}