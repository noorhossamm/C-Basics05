namespace Assignment_03
{
    internal class Program
    {

        #region Question01
        //static bool TryGetPrice(string title, out double price)
        //{
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }
        //    else
        //    {
        //        price = 0;
        //        return false;
        //    }
        //} 
        #endregion

        #region Question02
        //static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"Title: {title} , Pages: {pages}");
        //} 
        #endregion

        #region Question03
        //static void PrintBookInfo(string title, int pages )
        //{
        //    Console.WriteLine($"Title: {title} , Pages: {pages}");
        //}
        #endregion

        #region Question04
        //static void PrintAllTitles(params string[] titles)
        //{
        //    foreach (var title in titles)
        //    {
        //        Console.WriteLine(title);
        //    }

        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Question01
            //double price;
            //bool IsPriceFound = TryGetPrice("Clean Code", out price);
            //Console.WriteLine($"Price :{price}"); 
            #endregion

            #region Question02
            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Clean Code", 600); 
            #endregion

            #region Question03
            //PrintBookInfo(pages:400 , title:"Clean Code");
            #endregion

            #region Question04
            //PrintAllTitles("Refactoring", "Clean Code", "Design Patterns"); 
            #endregion

            #region Question05
            //Book b1 = new Book();
            //Console.WriteLine(b1.name); 
            // That is an error because the name field is private and cannot be accessed from outside the Book class.
            // Calling from main is inaccessible because it is private.
            #endregion

            #region Question06
            //Book b = new Book();
            //Console.WriteLine(b.copiesInStock); 
            #endregion







        }
    }
}
