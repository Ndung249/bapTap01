namespace BaiTapOOP
{
    public class Student : Person
    {
        public double DiemSo { get; set; }
        public override void An()
        {
            Console.WriteLine("an cut");
        }
        public override void In()
        {
            base.In();
            Console.WriteLine(DiemSo);
        }
    }
}
