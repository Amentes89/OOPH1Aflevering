using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes2
{
    internal abstract class Schooling
    {
        public SchoolingCategory SchoolingName { get; set; }
        public List<TECPerson> Teachers { get; set; }
        public List<string> Courses { get; set; }

        public Schooling(SchoolingCategory schoolingName)
        {
            SchoolingName = schoolingName;

            List<TECPerson> Teacher = new()
            {
                new TECPerson() { FullName = "Niels Olsen", Uddannelseslinje = schoolingName },
                new TECPerson() { FullName = "Bo Hansen", Uddannelseslinje = schoolingName },
                new TECPerson() { FullName = "Ole Nielsen", Uddannelseslinje = schoolingName }
            };
        }
        public virtual void SetCourses()
        {
            List<string> courses = new();
            Courses = courses;
            foreach (var displayCourses in (Enum.GetNames(typeof(CourseCatogory))))
            {
                courses.Add(displayCourses);
            }
        }
        public abstract void GetTeacher();

    }








}

