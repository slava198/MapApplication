using MapApplication.DAL;
using System.Collections.Generic;


namespace MapApplication.Entities
{
    public class CourseRepository
    {
        List<Course> courses;


        public CourseRepository()
        {
            courses = XmlHelper.DeserializeCourse();
        }


        public CourseRepository(List<Course> courses)
        {
            this.courses = courses;
        }


        public IEnumerable<Course> GetCourses()
        {
            return courses;
        }

    }
}
