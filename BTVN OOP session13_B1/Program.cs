using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        // BT1: Quản lý thông tin học sinh:
        // Thông tin: mã học sinh, tên học sinh, điểm Toán, điểm Văn, điểm Anh.
        // o Chức năng:
        // • Thêm thông tin học sinh.
        // • Tìm kiếm thông tin học sinh theo tên.
        // Cập nhật điểm số học sinh
        // * Tính điểm trung bình và xếp loại:
        // • DTB < 5: Yếu
        // • 5 <= DTB <= 6.5: Trung bình
        // 6.5 <= DTB < 8: Khá
        // * 8 <= DTB <= 10: Giỏi
        // * Xóa học sinh khỏi danh sách.
        // * Hiển thị danh sách học sinh kèm xếp loại học lực dựa trên điểm trung bình.
        // * Hiển thị học sinh theo điểm trung bình tăng dần (Dùng OrderBy)
        // * Hiển thị học sinh theo tên (Dùng OrderBy). Lưu ý xử lý chuỗi. Ví dụ: Trần Văn An => Tách ra sắp theo chữ An
        // Đọc ghi dữ liệu từ file json
        // * Thoát chương trình.
        Console.WriteLine("Hello, World!");
        studentManager = new StudentManager();

        while (true)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Thêm học sinh");
            Console.WriteLine("2. Tìm kiếm học sinh theo tên");
            Console.WriteLine("3. Cập nhật điểm học sinh");
            Console.WriteLine("4. Xóa học sinh");
            Console.WriteLine("5. Hiển thị danh sách học sinh");
            Console.WriteLine("6. Hiển thị học sinh theo điểm trung bình");
            Console.WriteLine("7. Hiển thị học sinh theo tên");
            Console.WriteLine("8. Thoát");
            Console.Write("Lựa chọn: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Thêm học sinh
                    AddStudent(studentManager);
                    break;
                case "2":
                    // Tìm kiếm học sinh
                    SearchStudent(studentManager);
                    break;
                case "3":
                    // Cập nhật điểm
                    UpdateStudentScores(studentManager);
                    break;
                case "4":
                    // Xóa học sinh
                    RemoveStudent(studentManager);
                    break;
                case "5":
                    // Hiển thị danh sách học sinh
                    studentManager.DisplayStudents();
                    break;
                case "6":
                    // Hiển thị học sinh theo điểm trung bình
                    studentManager.DisplayStudentsByAverageScore();
                    break;
                case "7":
                    // Hiển thị học sinh theo tên
                    studentManager.DisplayStudentsByName();
                    break;
                case "8":
                    // Thoát
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }

    static void AddStudent(StudentManager studentManager)
    {
        Console.Write("Nhập mã học sinh: ");
        string studentId = Console.ReadLine();
        Console.Write("Nhập tên học sinh: ");
        string fullName = Console.ReadLine();
        Console.Write("Nhập điểm Toán: ");
        int mathScore = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập điểm Văn: ");
        int literatureScore = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập điểm Anh: ");
        int englishScore = Convert.ToInt32(Console.ReadLine());

        student = new Student
        {
            StudentId = studentId,
            FullName = fullName,
            MathScore = mathScore,
            LiteratureScore = literatureScore,
            EnglishScore = englishScore
        };

        studentManager.AddStudent(student);
        Console.WriteLine("Thêm học sinh thành công!");
    }

    static void SearchStudent(StudentManager studentManager)
    {
        Console.Write("Nhập tên học sinh cần tìm: ");
        string name = Console.ReadLine();
        student = studentManager.FindStudentByName(name);
        if (student != null)
        {
            Console.WriteLine($"{student.FullName} - {student.AverageScore:F2} - {student.Grade}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy học sinh.");
        }
    }

    static void UpdateStudentScores(StudentManager studentManager)
    {
        Console.Write("Nhập mã học sinh cần cập nhật điểm: ");
        string studentId = Console.ReadLine();
        Console.Write("Nhập điểm Toán mới: ");
        int mathScore = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập điểm Văn mới: ");
        int literatureScore = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập điểm Anh mới: ");
        int englishScore = Convert.ToInt32(Console.ReadLine());

        studentManager.UpdateStudentScore(studentId, mathScore, literatureScore, englishScore);
        Console.WriteLine("Cập nhật điểm thành công!");
    }

    static void RemoveStudent(StudentManager studentManager)
    {
        Console.Write("Nhập mã học sinh cần xóa: ");
        string studentId = Console.ReadLine();
        studentManager.RemoveStudent(studentId);
        Console.WriteLine("Xóa học sinh thành công!");
    }
}