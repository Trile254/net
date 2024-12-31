internal class Program
{
    private static void Main(string[] args)
    {
        #region ly thuyet dong goi trong OOP 
        // Console.WriteLine("Hello, World!");
        // // tinh dong goi trong OOP (Encapsulation)
        // // gioi han pham vi truy cap cac thuoc tinh trong class
        // // nham bao ve du lieu cua class
        // // => cac thuoc tinh cua class nen duoc khai bao la private
        // // de truy cap vao cac thuoc tinh do, ta su dung cac phuong thuc getter va setter

        // // tao doi tuong person
        // // dung try...catch de bat loi neu co loi xay ra
        // try {
        // Person person = new Person();
        // // person.name = "Nguyen Van A"; // loi vi name la private
        // person.Name = "Nguyen Van A"; // di qua setter cua Name

        // person.Name = "A"; // loi vi ten khong hop le
        // Console.WriteLine("========");
        // Person person1 = new person("Nguyen Van A", 10);

        // } catch(ArgumentException ex) {
        // Console.WriteLine(ex.Message);
        // }
        #endregion

        // Bai tap:
        // 1. Tạo class cha Vehicle
        // - vehicleId: mã phương tiện
        // - brand: hãng xe
        // - year: năm sản xuất
        // - price: giá xe
        // 1.1 Tạo class Car kế thừa từ Vehicle
        // - model: dòng xe
        // - color: màu xe
        // - engine: dung tích động cơ
        // 1.2 Tạo class Motor kế thừa từ Vehicle
        // - type: loại xe (số tay, số tự động)
        // - power: công suất
        // Tạo class VehicleManager để quản lý phương tiện giao thông
        // - danh sách phương tiện
        // - file json lưu thông tin phương tiện (nâng cao)
        // 3. Yêu cầu chức năng
        // - Thêm phương tiện vào danh sách
        // * check xem mã phương tiện đã tồn tại chưa. Nếu có rồi thì báo lỗi.
        // lưu phương tiện mới vào file json (sử dụng thư viện Newtonsoft.Json)
        // - Hiển thị danh sách phương tiện
        // - Tìm phương tiện theo mã phương tiện
        // - Thoát

        // tao doi tuong VehicleManager
        VehicleManager vehicleManager = new VehicleManager();
        bool isRunning = true;
        while(isRunning) {
            Console.WriteLine("1. Them phuong tien");
            Console.WriteLine("2. Hien thi danh sach phuong tien");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Chon chuc nang (1-3):");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice) {
                case 1:
                    vehicleManager.addCar();
                    break;
                case 2:
                    vehicleManager.displayAllVehicle();
                    break;
                case 3:
                    isRunning= false;
                    break;
                default:
                    Console.WriteLine("Chức năng không hợp lệ");
                    break;            
            }
        }
    }    
}