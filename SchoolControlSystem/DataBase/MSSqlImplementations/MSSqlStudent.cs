using Microsoft.EntityFrameworkCore;
using SchoolControlSystem.Model;
using SchoolControlSystem.ModelServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolControlSystem.DataBase
{
    public class MSSqlStudent : IStudentDataBase
    {
        public SchoolContext schoolContext;

        public MSSqlStudent(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        public Student GetStudent(int ID)
        {
            return schoolContext.students.Include(s => s.grades)
                    .ThenInclude(g => g.Course)
                    .ThenInclude(c => c.courseSchedules)
                    .Single(s => s.ID.Equals(ID));
        }
        public void AddStudent(Student student)
        {
            schoolContext.students.Add(student);
            schoolContext.SaveChanges();
        }
        public Schedule GetSchedule(int ID)
        {
            int schoolHours = 9;
            Student student = GetStudent(ID);

            List<Course> courses = GetCourses(ID);
            Schedule studentSchedule = new Schedule();
            List<CourseSchedule> courseSchedule;

            foreach (var course in courses)
            {
                courseSchedule = course.courseSchedules;
                courseSchedule.Sort((x, y) => x.day.CompareTo(y.day));

                int i = 0;
                foreach (List<string> day in studentSchedule.schedule)
                {
                    for (int j = courseSchedule[i].initialHour - schoolHours; j < courseSchedule[i].endHour - schoolHours; j++)
                    {
                        day[j] = course.Code;
                    }
                    i++;
                }
            }

            return studentSchedule;
        }
        public List<CourseGrades> GetCourseGrades(int ID)
        {
            return GetStudent(ID).grades;
        }
        public List<Course> GetCourses(int ID)
        {
            List<Course> courses = new List<Course>();
            List<CourseGrades> courseGrades = GetCourseGrades(ID);

            foreach (var grade in courseGrades)
            {
                courses.Add(grade.Course);
            }

            return courses;
        }
        public void FillStudentDataBase()
        {
            string studentName;

            for(int i = 0; i< 5; i++)
            {
                studentName = "stu" + 1;

                AddStudent(new Student()
                {
                    name = studentName,
                    birthDate = DateTime.Now.AddYears(-20).ToShortDateString()
                });
            }

            schoolContext.SaveChanges();
        }
        public void AddCourse(int ID, string courseCode)
        {
            Student student = GetStudent(ID);
            Course course = schoolContext.courses.Find(courseCode);

            schoolContext.courseGrades.Add(new CourseGrades()
            {
                Course = course,
                Student = student
            });

            schoolContext.SaveChanges();
        }
        public bool CourseIsAvaliableToAdd(int ID, string courseCode)
        {
            int i = 0;
            List<CourseSchedule> courseSchedules = schoolContext.courses.Include(c => c.courseSchedules)
                                                    .Single(c => c.Code.Equals(courseCode))
                                                    .courseSchedules;
            List<Course> courses = GetCourses(ID);
            Student student = GetStudent(ID);

            if (Utilities.StudentTakesThisCourse(ID, courseCode))
            {
                return false;
            }

            courseSchedules.Sort((x, y) => x.day.CompareTo(y.day));

            foreach (var course in courses)
            {
                i = 0;
                foreach (var schedule in course.courseSchedules)
                {
                    if (courseSchedules[i].initialHour >= schedule.initialHour && courseSchedules[i].initialHour < schedule.endHour
                        || courseSchedules[i].endHour <= schedule.endHour && courseSchedules[i].endHour > schedule.initialHour)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public void DropCourse(int ID, string courseCode)
        {
            Student student = GetStudent(ID);
            Course course = schoolContext.courses.Find(courseCode);
            CourseGrades courseGrade = student.grades.Find(g => g.Course.Code.Equals(courseCode));

            schoolContext.courseGrades.Remove(courseGrade);
            schoolContext.SaveChanges();
        }
        public bool CourseIsAvaliableToDrop(int ID, string courseCode)
        {
            Student student = GetStudent(ID);

            if (student.grades.Find(g => g.Course.Code.Equals(courseCode)) != null)
            {
                return true;
            }
            return false;
        }
    }
}