

namespace List2
{
    internal class Student
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("id cua sinh vien la: " + this.ID);
            Console.WriteLine("Ten cua sinh vien la: " + this.Name);
            Console.WriteLine("Tuoi cua sinh vien la: " + this.Age);
            Console.WriteLine("Class cua sinh vien la: " + this.Class);
        }
    }
}
