using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using OrmLight.Linq;
using System.Linq;
//using OrmLight;
using OrmLight.Custom;

namespace OrmLight
{
    class Program
    {
        static void Main(string[] args)
        {
            var dal = new TestDataAccesLayer();

            var routeList = dal.Get<RouteEntity>().Where(r => r.Name.Equals("John")).OrderByDescending(r => r.Id).Take(20).Skip(10).ToList();
            //var routeList = dal.Get<RouteEntity>().Where(r => r.Name.Equals("John")).ToList();

            //var route = new RouteEntity();
            //route.Id = 42;
            //route.Name = "John";
            //route.Name = "John";

            //route.Name = null;
            //route.Id = -1;
            //route.Name = null;

            //route.Id = 17;
            //route.Name = "Bill";

            Console.ReadKey();
        }

        public static void NewTest()
        {

        }
    }

    

    //public class RouteEntity : EntityBase
    public class RouteEntity : EntityBase
    {
        private long _id;
        private string _name;

        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public long Id { get => _id; set => SetProperty(ref _id, value); }
    }
}
