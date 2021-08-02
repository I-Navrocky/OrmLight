using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using OrmLight.Linq;
using System.Linq;
using OrmLight.Context;
using System.Collections.Generic;

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

            //IEnumerable<RouteEntity> testList = new List<RouteEntity>();
            //testList.Where

            try
            {
                var dal = new TestDataAccesLayer();
                var list = dal.Get<RouteEntity>()
                    .Where(r => r.Id == 1).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }            
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
