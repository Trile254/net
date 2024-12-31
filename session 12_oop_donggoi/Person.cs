class Person {
    private string name;
    private int age;

    // dung property de truy cap vao tung thuoc tinh
    public string Name {
        get{ return name;}
        set{
            // them cac logic kiem tra gia tri truoc khi gan cho thuoc tinh
            // check ten khong duoc rong
            // hoac check ten co do dai toi thieu la 2 ky tu
            if(string.IsNullOrWhiteSpace(value) || value.Length < 2) {
                throw new ArgumentException("Ten khong hop le");
            }
            name = value;
        }
    }

    // tuong tu voi thuoc tinh age
    public int Age {
        get {return age;}
        set{
            if(value < 0 || value > 150) {
                throw new ArgumentExeception("Tuoi khong hop le");
            }
            age = value;
        }
    }
    // khi da define constructor moi, constructor mac dinh se khong tu sinh ra
    public Person(string name, int age) {
        // gan gia tri cho thuoc tinh thong qua setter (quan trong)
        Name = name;
        Age = age;
    }

    public Person() {}
    // luu y: neu da co constructor l]khac, can phai khai bo=ao constructor mac dinh (khong tham so)
}