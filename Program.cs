using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OrmLight
{
    class Program
    {
        static void Main(string[] args)
        {

            var route = new RouteEntity() { Name = "Test" };
            var dal = new DataAccesLayer();
            var com = dal.Get<RouteEntity>();

            Console.ReadKey();
        }
    }

    class RouteEntity : BaseEntity
    {
        private string _name;

        public string Name { get => _name; set => SetProperty(ref _name, value); }
    }
}
