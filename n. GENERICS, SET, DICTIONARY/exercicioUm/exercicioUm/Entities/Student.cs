namespace Curso
{
    internal class Student
    {
        public int ID { get; set; }

        public Student(int iD)
        {
            ID = iD;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student? other = obj as Student;
            return ID.Equals(other.ID);
        }
    }
}
