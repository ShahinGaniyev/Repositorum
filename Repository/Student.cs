namespace Repository
{
    internal class Student
    {
        private string name;
        private int grade;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                // Only allow grades between 0 and 100
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                }
            }
        }
    }
}
