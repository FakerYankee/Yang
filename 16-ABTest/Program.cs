using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ABTest
{
    class Vehicle
    {
        public string license;
        public int enginepower;
        public Vehicle() { ;}
        public Vehicle(string l, int e)
        {
            license = l;
            enginepower = e;
        }
        public virtual void Transportway()
        {
            Console.WriteLine("vechile");
        }
    }
    //Car
    class Car : Vehicle
    {
        public string color;
        public string type;
        public double maxspeed;

        public Car(string l, string c, string t, int e, double m)
            : base(l, e)
        {
            license = l;
            enginepower = e;
            maxspeed = m;
            color = c;
            type = t;
        }
        public override void Transportway()
        {
            Console.WriteLine("The Transportway is car.");
        }
    }
    //Plane
    class Plane : Vehicle
    {
        public double wingspan;
        public double loadcap;
        public double netweight;
        public string flyclass;

        public Plane(string l, double w, double load, int e, string fc,double nw)
            : base(l, e)
        {
            license = l;
            enginepower = e;
            flyclass = fc;
            wingspan = w;
            loadcap = load;
        }
        public override void Transportway()
        {
            Console.WriteLine("The Transportway is plane.");
        }
    }
    //Boat
    class Boat : Vehicle
    {
        public double gross;
        public double maxspeed;

        public Boat(string l, double g, int e, double m)
            : base(l, e)
        {
            license = l;
            enginepower = e;
            maxspeed = m;
            gross = g;
        }
        public override void Transportway()
        {
            Console.WriteLine("The Transportway is boat.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("NF123456", "GREEN", "PERSONAL", 147, 200);
            Car c2 = new Car("NF654321", "blue", "PERSONAL", 150, 195);
            Plane p = new Plane("LN1234",30,2,1000,"jet plane",10);
            Boat b=new Boat("ABC123",500,100,30);
            Console.WriteLine("Your vehicle is a boat and it's information are:registration is {0},maxspeed is {1},gross tonnage is {2} and enginepower is {3}", b.license, b.maxspeed, b.gross, b.enginepower);
           //Judge are the same or not
            if (c1 == c2)
            {
                Console.WriteLine("They are the same car!");
            }
            else
            {
                Console.WriteLine("They are not the same car!");
            }
            while (true)
            {
                Console.WriteLine("Please input the lciense of the car or plane:");
                string s = Console.ReadLine();
                if (s == "NF123456")
                {
                    c1.Transportway();
                    Console.WriteLine("It's information are:lciense is {0},color is {1},type is {2},enginepower is {3} and the maxspeed is {4}.", c1.license, c1.color, c1.type, c1.enginepower, c1.maxspeed);
                }
                else if (s == "NF654321")
                {
                    c2.Transportway();
                    Console.WriteLine("It's information are:lciense is {0},color is {1},type is {2},enginepower is {3} and the maxspeed is {4}.", c2.license, c2.color, c2.type, c2.enginepower, c2.maxspeed);
                }
                else if (s == "LN1234")
                {
                    p.Transportway();
                    Console.WriteLine("It's information are:registration is {0},wingspan is {1},netweight is {2},enginepower is {3} , the load capacity is {4} and flying class is {5}.", p.license, p.wingspan, p.netweight, p.enginepower, p.loadcap, p.flyclass);
                }
                else
                {
                    Console.WriteLine("Lciense or resigration dose not exist，please re-input。");
                }
            }
        }
    }
}
