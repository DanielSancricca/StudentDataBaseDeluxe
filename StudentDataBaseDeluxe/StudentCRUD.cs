using StudentDataBaseDeluxe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBaseDeluxe
{
    class StudentCRUD
    {
        StudentContext db = new StudentContext();

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }
        public Student GetStudent(int id)
        {
            Student output = db.Students.Find(id);
            return output;
        }
        public void CreateStudent(Student c)
        {
            db.Students.Add(c);
            db.SaveChanges();
        }
        public void UpdateStudent(Student updatedStudent, int id)
        {

            if (db.Students.Find(id) != null)
            {
                Student c = db.Students.Find(id);
                c.Name = updatedStudent.Name;
                c.Hometown = updatedStudent.Hometown;
                c.FavoriteFood = updatedStudent.FavoriteFood;
                c.FavoriteColor = updatedStudent.FavoriteColor;
                db.Update(updatedStudent);
                db.Update(updatedStudent);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"No student was found at {id} id.");
            }
        }
        public void DeleteStudent(int id)
        {
            Student studentToRemove = GetStudent(id);

            if (db.Students.Contains(studentToRemove))
            {
                db.Students.Remove(studentToRemove);
                db.SaveChanges();
            }
        }
    }
}
