using System;
using OrmLight;
using OrmLight.Linq;
using System.Linq;
using Example.AccessLayers;
using Example.Entities;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var dal = new ExampleAccessLayer();
            //var routeList = dal.Get<Person>().Where(r => r.Name.Equals("John")).OrderByDescending(r => r.Id).Take(20).Skip(10).ToList();
            //var persons = dal.Get<Person>().Where(r => r.Name.Equals("John")).OrderByDescending(r => r.Id).Take(20).Skip(10).Count();
            dal.Get<Person>().Where(r => r.Name.Equals("John")).Execute();

            Console.ReadKey();
        }
    }
}
