using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrmLight.Entities;

namespace OrmLight
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            var route = new RouteEntity() { Name = "Test" };
            var com = new Command<RouteEntity>(route);
            //
            Console.ReadKey();
        }
    }

    class RouteEntity : BaseEntity
    {
        private string _name;

        public string Name { get { return _name; } set { _name = value; } }
    }
}
