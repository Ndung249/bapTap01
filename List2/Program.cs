//Bài tập 2: Quản lý danh sách sinh viên bằng List
//Yêu cầu:
//Viết chương trình quản lý danh sách sinh viên bằng cách sử dụng List<Student>. Mỗi sinh viên có các thuộc tính: ID, Name, Age, Class.

//Các chức năng:

//Thêm sinh viên vào danh sách.
//Xóa sinh viên theo ID.
//Tìm kiếm sinh viên theo tên.
//Hiển thị tất cả sinh viên trong danh sách.
using List2;

List<Student> listStudent = new List<Student>();

int luaChon = 0;

do
{
    Console.Clear();
    Console.WriteLine("1. Them sinh vien");
    Console.WriteLine("2. Xoa sinh vien");
    Console.WriteLine("3. Tim kiem theo ten");
    Console.WriteLine("4. Tat ca sinh vien");
    Console.WriteLine("5. Thoat");
    Console.WriteLine("Nhap lua chon : ");

    bool isValidLC = int.TryParse(Console.ReadLine(), out luaChon);
    do
    {
        Console.Clear();
        if (!isValidLC)
        {
            Console.WriteLine("Nhap lua chon tu 1->5: ");
            isValidLC = int.TryParse(Console.ReadLine(), out luaChon);
        }
    } while (!isValidLC);
    switch (luaChon)
    {
        case 1:
            {
                Console.WriteLine("Hay nhap ID(Ma so sinh vien)");
                bool isValidId = int.TryParse(Console.ReadLine(), out int id);

                do
                {
                    Console.Clear();
                    if (isValidId == false)
                    {
                        Console.WriteLine("ban can phai nhap lai id: ");
                        isValidId = int.TryParse(Console.ReadLine(), out id);
                    }
                } while (isValidId == false);
                for (int i = 0; i < listStudent.Count; i++)
                {
                    if (listStudent[i].ID == id)
                    {
                        Console.WriteLine("Hay nhap lai id, id da bi trung: ");
                        isValidId = int.TryParse(Console.ReadLine(), out id);
                        do
                        {
                            Console.Clear();
                            if (isValidId == false)
                            {
                                Console.WriteLine("ban can phai nhap lai id: ");
                                isValidId = int.TryParse(Console.ReadLine(), out id);
                            }
                        } while (isValidId == false);

                    }
                }
                Console.WriteLine("Hay nhap Name(Ho va ten)");
                string name = Console.ReadLine();
                do
                {
                    Console.Clear();
                    if (string.IsNullOrEmpty(name))
                    {
                        Console.Write("Khong duoc de trong muc nay, vui long nhap lai: ");
                        name = Console.ReadLine();
                    }
                } while (string.IsNullOrEmpty(name));
                Console.WriteLine("Hay nhap Age(Tuoi sinh vien)");
                bool isValidAge = int.TryParse(Console.ReadLine(), out int age);
                do
                {
                    Console.Clear();
                    if (!isValidAge)
                    {
                        Console.WriteLine("Can phai nhap lai tuoi: ");
                        isValidAge = int.TryParse(Console.ReadLine(), out age);
                    }
                } while (!isValidAge);
                Console.WriteLine("Hay nhap Class(Lop hoc sinh vien)");
                string lop = Console.ReadLine();
                do
                {
                    Console.Clear();
                    if (string.IsNullOrEmpty(lop))
                    {
                        Console.Write("Khong duoc de muc nay trong, vui long nhap lai: ");
                        lop = Console.ReadLine();
                    }
                } while (string.IsNullOrEmpty(lop));
                Student student = new Student();
                student.ID = id;
                student.Name = name;
                student.Age = age;
                student.Class = lop;
                listStudent.Add(student);
                break;
            }
        case 2:
            {
                Console.WriteLine("Hay nhap id cua sinh vien ban muon xoa: ");
                int id = int.Parse(Console.ReadLine());
                for (int i = 0; i < listStudent.Count; i++)
                {
                    if (listStudent[i].ID == id)
                    {
                        listStudent.Remove(listStudent[i]);
                        break;

                    }
                }
                break;
            }
        case 3:
            {

                Console.WriteLine("Nhap ten sinh vien muon tim kiem: ");
                string name = Console.ReadLine();
                for (int i = 0; i < listStudent.Count; i++)
                {
                    if (listStudent[i].Name == name)
                    {
                        Console.WriteLine("Day la thong tin cua sinh vien ban muon tim : ");
                        listStudent[i].DisplayInfo();
                    }
                }
                Console.ReadKey();
                break;
            }
        case 4:
            for (int i = 0; i < listStudent.Count; i++)
            {
                listStudent[i].DisplayInfo();
            }
            Console.ReadKey();
            break;
        default:
            break;
    }
} while (luaChon != 5);
