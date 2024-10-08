﻿using LinqSkola.Data;
using LinqSkola.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LinqSkola.Controllers
{
    public class StudentsWithSubjectController : Controller
    {
        private readonly LinqSkolaDbContext _dbContext;
        private readonly ILogger<StudentsWithSubjectController> _logger;

        public StudentsWithSubjectController(LinqSkolaDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudentsWithSubject()
        {
            // Hämtar alla elever som läser "Programming 1" och deras lärare
            var studentsAndTeachers = _dbContext.StudentSubjects
                .Where(ss => ss.Subject.SubjectName == "Programming 1")
                .Select(ss => new
                {
                    Student = ss.Student,
                    Teacher = _dbContext.Teachers.FirstOrDefault(t => t.TeacherId == ss.Student.TeacherId)
                })
                .ToList();

            // Skapra en lista för att hålla elever och deras lärare
            var studentsAndTheirTeachers = new List<dynamic>();

            foreach (var item in studentsAndTeachers)
            {
                studentsAndTheirTeachers.Add(new
                {
                    StudentName = $"{item.Student.StudentFirstName} {item.Student.StudentLastName}",
                    TeacherName = item.Teacher != null ? $"{item.Teacher.TeacherFirstName} {item.Teacher.TeacherLastName}" : "No teacher assigned"
                });
            }

            return View(studentsAndTheirTeachers);
        }

    }
}
