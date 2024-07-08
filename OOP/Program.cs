using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {



        public struct Person
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public Person(string _FirstName, string _LastName, int _Age)
            {
                FirstName = _FirstName;
                LastName = _LastName;
                Age = _Age;
            }
            public void PrintFields()
            {
                Console.WriteLine();
                Console.WriteLine($"FirstName if {FirstName} LastName is {LastName} and AAge is {Age}");
                Console.WriteLine("_________________________________________________________");
            }
        }




        public struct Point
        {
            double X;
            double Y;
            public double Get_X()
            {
                return X;
            }
            public double Get_Y()
            {
                return Y;
            }
            public Point(double _X,double _Y)
            {
                X = _X;
                Y = _Y;
            }
            public static  bool operator ==(Point pt1,Point pt2)
            {
                return (pt1.X == pt2.X && pt1.Y == pt2.Y) ? true : false;
            }
            public static bool operator !=(Point pt1, Point pt2)
            {
                return (pt1.X != pt2.X || pt1.Y == pt2.Y) ? true : false;
            }
            public static Point operator +(Point pt1,Point pt2)
            {
                return new Point(pt1.Get_X() + pt2.Get_X(), pt1.Get_Y() + pt2.Get_Y());
            }
        }



        public struct Address
        {
            public string Street;
            public string City;
            public string PostalCode;

            public Address(string _Street,string _City,string _PostalCode)
            {
                Street = _Street;
                City = _City;
                PostalCode = _PostalCode;
            }
        }
        public struct PersonDate
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public Address address;

            public PersonDate(string _FirstName,string _LastName,int _Age,Address _address)
            {
                FirstName = _FirstName;
                LastName = _LastName;
                Age = _Age;
                address = _address;
            }

            public void PrintInfo()
            {
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine($"Person  First and Last names are  {FirstName} _ {LastName} and Age is {Age}");
                Console.WriteLine();
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine();
                Console.WriteLine($"(Address) Street {address.Street}  City {address.City}  PostalCode {address.PostalCode}");
            }
        }
        static void Main(string[] args)
        {



            Person person1 = new Person("Marry","Scot",45);
            Person person2 = new Person("Charley","Parker",20);
            Person person3 = new Person("David","Patinson",15);
            person1.PrintFields();
            person2.PrintFields();
            person3.PrintFields();
            Person[] people = new Person[] { person1, person2,person3 };
            int sum = 0;
            foreach (Person person in people) {
                sum += person.Age;
            }
            Console.WriteLine();
            Console.WriteLine( "AverageAge of Theese people is" + sum/people.Length);
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine();




            Point point = new Point(15,20);
            Point point1 = new Point(18,30);
            Point point2 = new Point(15,20);
            Console.WriteLine($"X:{point.Get_X()} Y:{point.Get_Y()}");
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("point == point1  " +  (point == point1));
            Console.WriteLine();
            Console.WriteLine("point == point2  " + (point == point2));
            Console.WriteLine();
            Console.WriteLine("point1 == point2  " + (point1 == point2));
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"(point + point1) pointers are (X:{(point+point1).Get_X()} Y:{(point + point1).Get_Y()})");




            Address address = new Address("123 street","New York","101548");
            PersonDate personDate = new PersonDate("Jessica","Davis",33,address);
            personDate.PrintInfo();
            Console.ReadLine();
        }
    }
}
