using System.Runtime.Intrinsics.X86;

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

            //int pages = 464;


            #endregion

            #region Quistion 4 
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block


            //try
            //{
            //    int result = 10 / 0;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion

            #region Quistion 5
            //Declare an int pages = 300; then store it in a double variable without using a cast

            //int pages = 30;

            //double num = pages;

            //Console.WriteLine(num);

            #endregion

            #region Quistion 6
            //Declare a double price = 49.99; then convert it into an int using a cast.

            //double price = 49.99;

            //int numb = (int)price;

            //Console.WriteLine(numb);

            #endregion

            #region Quistion 7
            //  Given string pagesText = "464";, convert it into an int using the Convert class.

            //string pagesText = "464";

            //int pages = Convert.ToInt32(pagesText);

            //Console.WriteLine(pages);

            #endregion

            #region Quistion 8
            // Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails

            //string yearText = "2023";

            //int year = int.Parse(yearText);

            //Console.WriteLine(year);

            //string badText = "abc";

            //if (int.TryParse(badText, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Quistion 9 
            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            //to prove it's now a string

            //int pages = 464;

            //string pagesText = pages.ToString();

            //Console.WriteLine(pagesText);
            //Console.WriteLine(pagesText.GetType());

            #endregion

            #region Quistion 10 
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            //variable, and print both

            int copies = 100;

            // Boxing
            object obj = copies;

            // Unboxing
            int newCopies = (int)obj;

            Console.WriteLine(obj);
            Console.WriteLine(newCopies);

            #endregion

        }





    }
    
}
