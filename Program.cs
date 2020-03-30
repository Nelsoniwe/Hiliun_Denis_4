using System;

namespace laba4_with_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Warship warship = new Warship("ASD",1000,50,125);

            warship.GetInfo();

            Console.ReadLine();

        }
    }

    interface IShip
    {
        string Name { get; set; }

        bool Gun { get;}

        int Cargo { get; set; }

        int CountPassangers { get; set; }

        void GetInfo();
    }

    class Warship : IShip
    {
        public int CountGun = 0;
        public string Name { get; set; }
        public bool Gun { get;}
        public int Cargo { get; set; }
        public int CountPassangers { get; set; }

        public Warship(string name, int cargo, int countpassangers, int countgun)
        {
            Name = name;
            Gun = true;
            CountGun = countgun;
            CountPassangers = countpassangers;
            Cargo = cargo;
        }

        public void GetInfo()
        {
            Console.WriteLine(Name + " " + CountGun + " " + CountPassangers + " " + Cargo);
        }
    }


    class CargoShip : IShip
    {
        public string Name { get; set; }
        public bool Gun { get; }
        public int Cargo { get; set; }
        public int CountPassangers { get; set; }

        public CargoShip(string name, int cargo, int countpassangers)
        {
            Name = name;
            Gun = false;
            CountPassangers = countpassangers;
            Cargo = cargo;
        }

        public void GetInfo()
        {
            Console.WriteLine(Name + " " + CountPassangers + " " + Cargo);
        }
    }


    class Fregat : IShip
    {
        public string Name { get; set; }
        public bool Gun { get;}
        public int Cargo { get; set; }
        public int CountPassangers { get; set; }

        public Fregat(string name, int cargo, int countpassangers)
        {
            Name = name;
            Gun = false;
            CountPassangers = countpassangers;
            Cargo = cargo;
        }

        public void GetInfo()
        {
            Console.WriteLine(Name + " " + CountPassangers + " " + Cargo);
        }
    }
    class Parom : IShip
    {

        public string Name { get; set; }
        public bool Gun { get; }
        public int Cargo { get; set; }
        public int CountPassangers { get; set; }


        public Parom(string name, int cargo, int countpassangers)
        {
            Name = name;
            Gun = false;
            CountPassangers = countpassangers;
            Cargo = cargo;
        }

        public void GetInfo()
        {
            Console.WriteLine(Name + " " + CountPassangers + " " + Cargo);
        }
    }




}
