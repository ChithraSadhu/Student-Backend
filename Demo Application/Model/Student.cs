using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Application.Model
{
    public class Student
    {
        [Key]

        public int id { get; set; }
        public string name { get; set; }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Student(string name) {
            this.name = name;
        }
        public Student()
        {
            
        }
    }
}
