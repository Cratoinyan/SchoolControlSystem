using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SchoolControlSystem.Model;

namespace SchoolControlSystem.DataBase
{
    public class MSSqlInstructor : IInstructorDataBase
    {
        public SchoolContext schoolContext;

        public MSSqlInstructor(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        public void AddInstructor(Instructor instructor)
        {
            schoolContext.instructors.Add(instructor);
            schoolContext.SaveChanges();
        }
        public void UpdateStudentGrade(int ID, string courseCode, int grade)
        {
            Student student = schoolContext.students.Include(s => s.grades)
                                                    .ThenInclude(g => g.Course)
                                                    .Single(s => s.ID.Equals(ID));

            student.grades.Single(g => g.Course.Code.Equals(courseCode)).grade = grade;

            schoolContext.SaveChanges();
        }

        public void FillInstructorDataBase()
        {
            string instructorName;

            for(int i = 0; i<5; i++)
            {
                instructorName = "ins" + i;

                schoolContext.instructors.Add(new Instructor()
                {
                    name = instructorName,
                    birthDate = DateTime.Now.AddYears(-40).ToShortDateString()
                });
            }

            schoolContext.SaveChanges();
        }

        public List<Instructor> GetInstructors()
        {
            return schoolContext.instructors.ToList();
        }
        public List<Student> GetCourseStudentList(string courseCode)
        {
            Course course = schoolContext.courses.Include(c => c.CourseGrades)
                                                .ThenInclude(g => g.Student)
                                                .Single(c => c.Code.Equals(courseCode));

            List<Student> students = new List<Student>();

            foreach (var grade in course.CourseGrades)
            {
                students.Add(grade.Student);
            }

            return students;
        }
        public List<Student> GetInstructorStudentList(int instructorID)
        {
            List<Student> studentsToReturn = new List<Student>();
            List<Student> students = new List<Student>();
            List<Course> courses = schoolContext.courses.Include(c => c.CourseGrades)
                                                        .ThenInclude(g => g.Student)
                                                        .Where(x => x.instructor.ID.Equals(instructorID))
                                                        .ToList();

            foreach (var course in courses)
            {
                foreach (var grade in course.CourseGrades)
                {
                    students.Add(grade.Student);
                }

                if (studentsToReturn.Count == 0)
                {
                    studentsToReturn = new List<Student>(students);
                }
                else
                {
                    studentsToReturn.Union(students);
                }
            }
            return studentsToReturn;
        }
        public void fillInstructorDataBase()
        {
            for(int i = 0 ;i < 5; i++)
            {
                schoolContext.instructors.Add(new Instructor()
                {
                    name = ("inst" + (i + 1)),
                    birthDate = DateTime.Now.ToString()
                });

                schoolContext.SaveChanges();
            }
        }
    }


    

}
