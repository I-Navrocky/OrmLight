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

            //var route = new RouteEntity() { Name = "Test" };
            //var dal = new DataAccesLayer();        
            //var com = dal.Get<RouteEntity>().Where(r => r.Id == 1);
            //var com2 = com.Where(r => r.Id == 2);

            var dal = new TestDataAccesLayer();

            var list = dal.Get().Where(n => n.Equals("John")).ToList();

            Console.ReadKey();
        }
    }

    class RouteEntity : BaseEntity
    {
        private long _id;
        private string _name;

        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public long Id { get => _id; set => SetProperty(ref _id, value); }
    }
}
