using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes2
{
    internal class Courses : Schooling
    {
        public List<string> SchoolingCourses { get; set; }

        public Courses(SchoolingCategory schoolingName) : base(schoolingName)
        {
            SchoolingName = schoolingName;
        }
        public override void SetCourses()
        {
            List<string> schoolCources = new();
            SchoolingCourses = schoolCources;
            base.SetCourses();

            if (SchoolingName == SchoolingCategory.Programmeringslinje)
            {
                foreach (string displayCourses in (Enum.GetNames(typeof(CourseCatogory))))
                {
                    schoolCources.Add(Courses.FirstOrDefault(a => a.Contains("Programmering")));
                }
            }
            if (SchoolingName == SchoolingCategory.Infrastrukturlinje)
            {
                foreach (string displayCourses in (Enum.GetNames(typeof(CourseCatogory))))
                {
                    schoolCources.Add(Courses.FirstOrDefault(a => a.Contains("Netværk")));
                }
            }
            if (SchoolingName == SchoolingCategory.Supporterlinje)
            {
                foreach (string displayCourses in (Enum.GetNames(typeof(CourseCatogory))))
                {
                    schoolCources.Add(Courses.FirstOrDefault(a => a.Contains("Server")));
                }
            }
        }
        public override void GetTeacher()
        {
            
        }
    }
}
