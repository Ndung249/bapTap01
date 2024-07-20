namespace Management
{
    //Lớp FullTimeEmployee kế thừa từ Employee:
    //Thuộc tính bổ sung: Bonus(thưởng thêm).
    //Phương thức CalculateSalary() được ghi đè để tính lương tổng(lương cơ bản + thưởng).
    public class FullTimeEmployee : Employee

    {
        public int Bonus { get; set; }

        protected override double CalculateSalary()
        {
            return Salary + Bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Tong luong cua nv FullTime:  " + CalculateSalary());
        }
    }
}
