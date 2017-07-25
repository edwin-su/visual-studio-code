using Autofac;
using Autofac.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterType<DBManager>();
            //builder.RegisterType<SqlDAL>().As<IDAL>().SingleInstance(); //Can select between SqlDAL and OracleDAL
            //using (var container = builder.Build())
            //{
            //    var dal = container.Resolve<IDAL>();
            //    dal.Insert("INSERT INTO Persons VALUES ('Man', '25', 'WangW', 'Shanghai')");
            //}


            //ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<DBManager>();
            //builder.RegisterType<SqlDAL>().As<IDAL>().SingleInstance();
            //builder.Register(c => new DBManager(c.Resolve<IDAL>()));

            //using (IContainer container = builder.Build())
            //{
            //    DBManager manager = container.Resolve<DBManager>();
            //    manager.Add("INSERT INTO Persons VALUES ('Man', '25', 'WangW', 'Shanghai')");
            //}


            /* Get autofac configure from app.config */
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<DBManager>();
            builder.RegisterModule(
                new ConfigurationSettingsReader("autofac"));
            using (IContainer container = builder.Build())
            {

                DBManager manager = container.Resolve<DBManager>();
                manager.Add("INSERT INTO Persons VALUES ('Man', '25', 'WangW', 'Shanghai')");
            }

            Console.ReadKey();
        }
    }
}
