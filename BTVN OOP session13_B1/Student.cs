public class Student
{
    public string StudentId { get; set; }  // Mã học sinh
    public string FullName { get; set; }    // Tên học sinh
    public int MathScore { get; set; }   // Điểm Toán
    public int LiteratureScore { get; set; } // Điểm Văn
    public int EnglishScore { get; set; } // Điểm Anh

    // Tính điểm trung bình
    public int AverageScore => (MathScore + LiteratureScore + EnglishScore) / 3;

    // Xếp loại dựa trên điểm trung bình
    public string Grade
    {
        get
        {
            if (AverageScore < 5) return "Yếu";
            if (AverageScore <= 6.5) return "Trung bình";
            if (AverageScore < 8) return "Khá";
            return "Giỏi";
        }
    }
}