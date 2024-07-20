//Bài tập 1: Tìm số lớn thứ hai trong mảng
//Yêu cầu:
//Viết chương trình tìm số lớn thứ hai trong một mảng các số nguyên.

//Hướng dẫn:

//Khai báo và khởi tạo một mảng số nguyên.
//Sử dụng vòng lặp để duyệt qua mảng và tìm số lớn nhất.
//Sử dụng vòng lặp khác để tìm số lớn thứ hai.

int[] numbers = new int[7];
numbers[0] = 8;
numbers[1] = 7;
numbers[2] = 18;
numbers[3] = 2;
numbers[4] = 6;
numbers[5] = 19;
numbers[6] = 21;


for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        int current = numbers[i];
        int next = numbers[j];
        if (current > next)
        {
            int temp = current;
            current = next; next = temp;

        }
    }
}
Console.WriteLine("gia tri lon thu nhi la " + numbers[numbers.Length - 2]);
