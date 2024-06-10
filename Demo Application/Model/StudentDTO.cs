namespace Demo_Application.Model
{
    public class StudentDTO
    {
        private int id;
        private string name;
        StudentDTO(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
    }
}
