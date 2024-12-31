class Student {
    public string studentId;
    public string studentName;
    public int age;

    public Student(string studentId, string studentName, int age) {
        this.studentId = studentId;
        this.studentName = studentName;
        this.age = age;
    }

    // phuong thuc hien thi thong tin sinh vien
    public void displayInfo() {
        Console.WriteLine($"ID: {studentID}, Name: {studentName}, Age: {studentAge}");
    }
}