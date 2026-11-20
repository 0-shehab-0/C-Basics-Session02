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

            Book book = new Book
            {
                Title = "Name",
                Pages = 100
            };

            object obj = book;

            Console.WriteLine(obj);


            #endregion



        }
    }
}
