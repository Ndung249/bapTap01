namespace BaiTapOOP
{
    //Tạo lớp Person và các lớp con Student, Teacher kế thừa từ lớp Person.Thêm các thuộc tính và phương thức phù hợp cho từng lớp.
    public class Person
    {
        public string Name { get; set; }
        public double Age { get; set; }

        public virtual void An()
        {
            Console.WriteLine("an rac ");
        }
        public virtual void In()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
        }

    }
}
