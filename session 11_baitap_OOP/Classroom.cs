class Classroom {
    // thuoc tinh
    public string classId;
    public string className;
    public List<Student> students;

    // constructor
    public Classroom(string classId, string className) {
        this.classId = classId;
        this.className = className;
        this.students = new List<Student>();
    }

    // phuong thuc them sinh vien vao lop 
    public void addStudent(Student student) {
        students.Add(student);
        Console.WriteLine($"Student {student.studentName} add to class {className}");
    }

    // phuong thuc hien thi danh sach sinh vien trong lop
    public void showStudent() {
        Console.WriteLine($"\n ----Students in class {className}----");
        foreach (Student student in students) {
            Console.WriteLine($"ID: {studentID}, Name: {studentName}, Age: {studentAge}");
            student.displayInfo();
        }
    }

    // phuong thuc tim kiem sinh vien theo ma sinh vien
    public void findStudentByStudentId(string studentID) {
        // C1: Dung vong lap
        foreach (Student student in students) {
            if(student.studentID == studentID) {
                student.displayInfo();
                return;
            }
        }
        // trong truong hop duyet het danh sach ma khong co sinh vien nao.
        Console.WriteLine($"Student with Id {studentId} not found in class {className}");
    }
}