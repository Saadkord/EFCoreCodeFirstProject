using EFCore.Data;
using EFCore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var Context = new AppDbContext())
            {

                var sections = Context.Sections.Include(x => x.Course).Include(x => x.Instractor).Include(x => x.Secheduals);
                foreach (var section in sections)
                {
                    var sun = section.Secheduals.SUN ? "x" : "";
                    var mon = section.Secheduals.MON ? "x" : "";
                    var tue = section.Secheduals.TUE ? "x" : "";
                    var wed = section.Secheduals.WED ? "x" : "";
                    var the = section.Secheduals.THE ? "x" : "";
                    var fri = section.Secheduals.FRI ? "x" : "";
                    var sat = section.Secheduals.SAT ? "x" : "";

                    Console.WriteLine($"{section.Id} --- {section.SectionName} ---- {section.Course.CourseName} --- {section.Instractor.FName} {section.Instractor.LName} --- {section.Secheduals.Title} --- {section.TimeSlot} --- {sun} - {mon} - {tue} - {wed} - {the} - {fri} - {sat} ");
                }

            }
            Console.ReadKey();
        }
    }
}
