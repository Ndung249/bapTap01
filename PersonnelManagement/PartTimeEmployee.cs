namespace Management
{
    //Lớp PartTimeEmployee kế thừa từ Employee:
    //Thuộc tính bổ sung: HoursWorked(số giờ làm việc), HourlyRate(mức lương theo giờ).
    //Phương thức CalculateSalary() được ghi đè để tính lương tổng(số giờ làm việc * mức lương theo giờ).
    public class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }

        protected override double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Tong luong cua nv PartTime:  " + CalculateSalary());
        }
    }
}
