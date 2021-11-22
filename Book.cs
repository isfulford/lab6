namespace lab6
{
    public class Book
    {
        private string isbn;
        private string title;
        Author author;
        public Book(string tempIsbn, string tempTitle, Author tempAuthor){
            this.isbn = tempIsbn;
            this.title = tempTitle;
            this.author = tempAuthor;
        }
        public string GetIsbn(){
            return isbn;
        }
        public void SetIsbn(string tempIsbn){
            this.isbn = tempIsbn;
        }
        public string GetTitle(string tempTitle){
            return title;
        }
        public void SetTitle(string tempTitle){
            this.title = tempTitle;
        }
        public Author GetAuthor(){
            return author;
        }
        public override string ToString(){
            return "isbn = " + isbn + ", title = " + title + ", " + author.ToString();
        }
    }
}