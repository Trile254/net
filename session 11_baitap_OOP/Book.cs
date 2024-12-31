class Book {
    public string bookId;
    public string bookName;
    public string author;
    public int price;

    public Book(string bookId, string bookName, string author, int price) {
        this.booktId = bookId;
        this.bookName = bookName;
        this.author = author;
        this.price = price;
    }

    // phuong thuc hien thi thong tin sach
    public void displayInfo() {
        Console.WriteLine($"ID: {bookID}, Name: {bookName}, Author:{bookAuthor}, Price: {bookPrice}");
    }
}