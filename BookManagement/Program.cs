using BookManagement;

Library library = new Library();

// Create some books
Book book1 = new Book("Book 1", "Content of Book 1");
Book book2 = new Book("Book 2", "Content of Book 2");

// Add books to library
library.AddBook(book1);
library.AddBook(book2);

// Display books in library
library.DisplayBooks();

// Remove a book from library
library.RemoveBook(book1);

// Display books in library after removal
library.DisplayBooks();
