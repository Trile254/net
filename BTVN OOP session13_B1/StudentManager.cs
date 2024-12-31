class StudentManager
{
    private List<Student> students;
    private const string FilePath = "students.json";

    public StudentManager()
    {
        students = LoadDataFromFile();
    }

    // Thêm học sinh
    public void AddStudent(Student student)
    {
        students.Add(student);
        SaveDataToFile();
    }

    // Tìm kiếm học sinh theo tên
    public Student FindStudentByName(string name)
    {
        return students.FirstOrDefault(s => s.FullName.Contains(name, StringComparison.OrdinalIgnoreCase));
    }

    // Cập nhật điểm học sinh
    public void UpdateStudentScore(string studentId, int mathScore, int literatureScore, int englishScore)
    {
        var student = students.FirstOrDefault(s => s.StudentId == studentId);
        if (student != null)
        {
            student.MathScore = mathScore;
            student.LiteratureScore = literatureScore;
            student.EnglishScore = englishScore;
            SaveDataToFile();
        }
    }

    // Xóa học sinh
    public void RemoveStudent(string studentId)
    {
        var student = students.FirstOrDefault(s => s.StudentId == studentId);
        if (student != null)
        {
            students.Remove(student);
            SaveDataToFile();
        }
    }

    // Hiển thị danh sách học sinh
    public void DisplayStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"{student.FullName} - {student.AverageScore:F2} - {student.Grade}");
        }
    }

    // Hiển thị danh sách học sinh theo điểm trung bình tăng dần
    public void DisplayStudentsByAverageScore()
    {
        var sortedStudents = students.OrderBy(s => s.AverageScore).ToList();
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.FullName} - {student.AverageScore:F2} - {student.Grade}");
        }
    }

    // Hiển thị học sinh theo tên
    public void DisplayStudentsByName()
    {
        var sortedStudents = students.OrderBy(s => s.FullName.Split(' ').Last()).ToList();
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.FullName} - {student.AverageScore:F2} - {student.Grade}");
        }
    }

    // Lưu dữ liệu vào file JSON
    private void SaveDataToFile()
    {
        var jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
        File.WriteAllText(FilePath, jsonData);
    }

    // Đọc dữ liệu từ file JSON
    private List<Student> LoadDataFromFile()
    {
        if (!File.Exists(FilePath)) return new List<Student>();

        var jsonData = File.ReadAllText(FilePath);
        return JsonConvert.DeserializeObject<List<Student>>(jsonData) ?? new List<Student>();
    }
}