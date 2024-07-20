namespace Management
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Danh sách nhân viên:
            //Tạo danh sách chứa các đối tượng nhân viên khác nhau(bao gồm cả nhân viên toàn thời gian và nhân viên bán thời gian).
            //Sử dụng tính đa hình để tính và hiển thị tổng lương của tất cả các nhân viên trong danh sách.
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.Name = "Test";
            fullTimeEmployee.ID = 001;
            fullTimeEmployee.Salary = 7000000;
            fullTimeEmployee.Bonus = 500000;
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.Name = "/FF";
            partTimeEmployee.ID = 002;
            partTimeEmployee.HoursWorked = 120;
            partTimeEmployee.HourlyRate = 15000;
            List<Employee> employees = new List<Employee>();

            employees.Add(fullTimeEmployee);
            employees.Add(partTimeEmployee);

            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].DisplayInfo();
            }
        }
    }
}