using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using OrmLight.Linq;
using OrmLight.Custom;
using System.Linq;

namespace OrmLight
{
    class Program
    {
        static void Main(string[] args)
        {
            var dal = new TestDataAccesLayer();

            //var stringList = dal.GetString().Where(n => n.Equals("John")).ToList();
            //var routeList = dal.Get<RouteEntity>().Where(r => r.Id == 1 || r.Id == 2 || r.Id == 3).ToList();
            var routeList = dal.Get<RouteEntity>().Where(r => r.Name.Equals("John")).ToList();

            Console.ReadKey();
        }
    }

    public class RouteEntity : BaseEntity
    {
        private long _id;
        private string _name;

        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public long Id { get => _id; set => SetProperty(ref _id, value); }
    }
}
