using LinqSkola.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinqSkola.Controllers
{
    public class StudentsWithTeachersController : Controller
    {
        private readonly LinqSkolaDbContext _dbContext;

        public StudentsWithTeachersController(LinqSkolaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudentsWithTeacher()
        {
            var studentsWithTeacher = _dbContext.Students
          .Include(s => s.StudentSubjects)
          .ThenInclude(ss => ss.Subject)
              .ThenInclude(sub => sub.TeacherSubjects)
                  .ThenInclude(ts => ts.Teacher)
          .ToList();

            return View(studentsWithTeacher);
        }
        
    }
}
