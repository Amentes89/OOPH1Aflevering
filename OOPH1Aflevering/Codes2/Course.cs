using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes2
{
    internal sealed class Courses : Schooling
    {
        public List<string> SchoolingCourses { get; set; }

        public Courses(SchoolingCategory schoolingName) : base(schoolingName)
        {
            SchoolingName = schoolingName;
        }
        public override void SetCourses()
        {
            base.SetCourses();
           
            if (SchoolingName == SchoolingCategory.Programmeringslinje)
            {

                List<string> schoolingCourses = Courses.Where(a => a.Contains("Programmering")).ToList();
                SchoolingCourses = schoolingCourses;
                
            }
            if (SchoolingName == SchoolingCategory.Infrastrukturlinje)
            {

                List<string> schoolingCourses = Courses.Where(a => a.Contains("Netværk")).ToList();
                SchoolingCourses = schoolingCourses;

            }
            if (SchoolingName == SchoolingCategory.Supporterlinje)
            {

                List<string> schoolingCourses = Courses.Where(a => a.Contains("Server")).ToList();
                SchoolingCourses = schoolingCourses;


            }
        }
        public override void GetTeacher()
        {
            //foreach (string displayteacher in (Enum.GetNames(typeof(Colorsignal))))
            //{
            //    Console.WriteLine();
            //}
        }
    }
}
