class Library {
    // thuoc tinh
    public string libraryId;
    public string libraryName;
    public List<Book> books;

    // constructor
    public Library(string libraryId, string libraryName) {
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        this.books = new List<Book>();
    }

    // phuong thuc them sach vao lop 
    public void addBook(Book book) {
        books.Add(book);
        Console.WriteLine($"Book {book.bookName} add to library {libraryName}");
    }

    // phuong thuc hien thi danh sach sach trong lop
    public void showBook() {
        Console.WriteLine($"\n ----Books in library {libraryName}----");
        foreach (Book book in books) {
            Console.WriteLine($"ID: {bookID}, Name: {bookName}, Author:{bookAuthor}, Price: {bookPrice}");
            book.displayInfo();
        }
    }

    // phuong thuc tim kiem sach theo ma sach
    public void findBookByBookId(string bookID) {
        // C1: Dung vong lap
        foreach (Book book in books) {
            if(book.bookID == bookID) {
                book.displayInfo();
                return;
            }
        }
        // trong truong hop duyet het danh sach ma khong co sach nao.
        Console.WriteLine($"Book with Id {bookId} not found in library {libraryName}");
    }
}
