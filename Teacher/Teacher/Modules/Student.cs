namespace Teacher.Modules
{
    public class Student
    {
        public int Id;
        public string Name;

        public Student() { }

        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Id + Name;
        }
    }
}
