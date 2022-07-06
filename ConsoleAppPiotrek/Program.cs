using System;

namespace ConsoleAppPiotrek
{
    class Program
    {
        static void Main(string[] args)
        {
            DbService db = null;
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        db = new DbService(new Sql());
                        break;
                    }
                case "2":
                    {
                        db = new DbService(new FireBird());
                        break;
                    }
            }

            db.runAll();
        }
    }

    public class DbService
    {
        public ICRUD ICrud { get; }
        public DbService(ICRUD iCrud)
        {
            ICrud = iCrud;
        }

        public void runAll()
        {
            ICrud.Create();
            ICrud.Read();
            ICrud.Update();
            ICrud.Delete();
        }
        
    }


    public class Sql : ICRUD
    {
        public void Create()
        {
            Console.WriteLine(this.GetType().Name + "Create");
        }

        public void Delete()
        {
            Console.WriteLine(this.GetType().Name + "Delete");
        }

        public void Read()
        {
            Console.WriteLine(this.GetType().Name + "Read");
        }

        public void Update()
        {
            Console.WriteLine(this.GetType().Name + "Update");
        }
    }

    public class FireBird : ICRUD
    {
        //public void Create()
        //{
        //    Console.WriteLine(this.GetType().Name + "Create");
        //}

        public void Delete()
        {
            Console.WriteLine(this.GetType().Name + "Delete");
        }

        public void Read()
        {
            Console.WriteLine(this.GetType().Name + "Read");
        }

        public void Update()
        {
            Console.WriteLine(this.GetType().Name + "Update");
        }
    }

    public interface ICRUD
    {
        void Create()
        {
            Console.WriteLine("aaa");
        }
        void Read();
        void Update();
        void Delete();
    }

    public abstract class Domek
    {
        public Domek()
        {

        }
        public void disp()
        {
            Console.WriteLine("aaa");
        }

        public abstract void disp2();
    }
}
