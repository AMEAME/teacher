namespace Teacher.Modules
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

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
