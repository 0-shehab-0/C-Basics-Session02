namespace C__Basics_Session02
{
    internal class Program
    {

        class Book
        {
            public string Title;
            public int Pages;
        }


        static void Main(string[] args)
        {
            #region Question 1
            // 1- Create a Book class with a Title (string) and Pages (int).
            // Create a Book object and store it in a variable of type object. Print it.

            //Book book = new Book
            //{
            //    Title = "Name",
            //    Pages = 100
            //};

            //object obj = book;

            //Console.WriteLine(obj);


            #endregion

            #region Question 2
            //// Using the Book class above, print the result of calling ToString(),
            //// Equals() (compare book with
            ////itself), GetHashCode(), and GetType() on book.

            //Book book1 = new Book
            //{
            //    Title = "Name",
            //    Pages = 100
            //};

            //Book book2 = new Book
            //{
            //    Title = "Namee",
            //    Pages = 1000
            //};

            //object obj1 = book1;
            //object obj2 = book2;

            //Console.WriteLine(book1.ToString());
            //Console.WriteLine(book1.Equals(book2));

            //Console.WriteLine(book1.GetHashCode());
            //Console.WriteLine(book2.GetHashCode());

            //Console.WriteLine(book1.GetType());

            #endregion

            #region Question 3
            //Look at the line below.Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";

            //sytax error

            int pages = 464;


            #endregion


        }





    }
    
}
