using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_KatherineChambers18003948
{
    class LibraryManager
    {
        /*        public static List<Book> getBooks1()
                {
                    List<Book> book = new List<Book>();

                    book.Add(new Book { numbers = "363.46", letters = "ABC" });
                    book.Add(new Book { numbers = "362.29", letters = "BCD" });
                    book.Add(new Book { numbers = "362.235", letters = "CDE" });
                    book.Add(new Book { numbers = "305.734", letters = "DEF" });
                    book.Add(new Book { numbers = "659.1", letters = "EFG" });
                    book.Add(new Book { numbers = "305.896", letters = "FGH" });
                    book.Add(new Book { numbers = "365.933", letters = "GHI" });
                    book.Add(new Book { numbers = "302.54", letters = "HIJ" });
                    book.Add(new Book { numbers = "624.7", letters = "IJK" });
                    book.Add(new Book { numbers = "808.813", letters = "JKL" });

                    return book;
                }*/

        /*        public static List<Book> getBookAnswer1()
                {
                    List<Book> bookAnswer = new List<Book>();
                    bookAnswer.Add(new Book { numbers = "302.54", letters = "HIJ" });
                    bookAnswer.Add(new Book { numbers = "305.734", letters = "DEF" });
                    bookAnswer.Add(new Book { numbers = "305.896", letters = "FGH" });
                    bookAnswer.Add(new Book { numbers = "362.235", letters = "CDE" });
                    bookAnswer.Add(new Book { numbers = "362.29", letters = "BCD" });
                    bookAnswer.Add(new Book { numbers = "363.46", letters = "ABC" });
                    bookAnswer.Add(new Book { numbers = "365.933", letters = "GHI" });
                    bookAnswer.Add(new Book { numbers = "624.7", letters = "IJK" });
                    bookAnswer.Add(new Book { numbers = "659.1", letters = "EFG" });
                    bookAnswer.Add(new Book { numbers = "808.813", letters = "JKL" });
                    return bookAnswer;
                }*/

        //1
        public static List<Book> getBooks1()
        {
            List<Book> book = new List<Book>();

            book.Add(new Book { dewey = "363.46ABC" });
            book.Add(new Book { dewey = "362.29BCD" });
            book.Add(new Book { dewey = "362.235CDE" });
            book.Add(new Book { dewey = "305.734DEF" });
            book.Add(new Book { dewey = "659.1EFG" });
            book.Add(new Book { dewey = "305.896FGH" });
            book.Add(new Book { dewey = "365.933GHI" });
            book.Add(new Book { dewey = "302.54HIJ" });
            book.Add(new Book { dewey = "624.7IJK" });
            book.Add(new Book { dewey = "808.813JKL" });

            return book;
        }

        public static List<Book> getBookAnswer1()
        {
            List<Book> bookAnswer = new List<Book>();
            bookAnswer.Add(new Book { dewey = "302.54HIJ" });
            bookAnswer.Add(new Book { dewey = "305.734DEF" });
            bookAnswer.Add(new Book { dewey = "305.896FGH" });
            bookAnswer.Add(new Book { dewey = "362.235CDE" });
            bookAnswer.Add(new Book { dewey = "362.29BCD" });
            bookAnswer.Add(new Book { dewey = "363.46ABC" });
            bookAnswer.Add(new Book { dewey = "365.933GHI" });
            bookAnswer.Add(new Book { dewey = "624.7IJK" });
            bookAnswer.Add(new Book { dewey = "659.1EFG" });
            bookAnswer.Add(new Book { dewey = "808.813JKL" });
            return bookAnswer;
        }

        //2
        public static List<Book> getBooks2()
        {
            List<Book> book = new List<Book>();

            book.Add(new Book { dewey = "659.2IVD" });
            book.Add(new Book { dewey = "356.157KDR" });
            book.Add(new Book { dewey = "123.321OUT" });
            book.Add(new Book { dewey = "356.15POU" });
            book.Add(new Book { dewey = "458.268BFJ" });
            book.Add(new Book { dewey = "102.256KHU" });
            book.Add(new Book { dewey = "402.567FTJ" });
            book.Add(new Book { dewey = "856.124MJH" });
            book.Add(new Book { dewey = "402.567BGH" });
            book.Add(new Book { dewey = "124.356LDR" });
            book.Add(new Book { dewey = "896.246UTR" });
            book.Add(new Book { dewey = "156.259UYT" });
            book.Add(new Book { dewey = "102.256IJR" });
            book.Add(new Book { dewey = "536.458LGR" });
            book.Add(new Book { dewey = "259.156OIP" });

            return book;
        }

        public static List<Book> getBookAnswer2()
        {
            List<Book> bookAnswer = new List<Book>();
            bookAnswer.Add(new Book { dewey = "102.256IJR" });
            bookAnswer.Add(new Book { dewey = "102.256KHU" });
            bookAnswer.Add(new Book { dewey = "123.321OUT" });
            bookAnswer.Add(new Book { dewey = "124.356LDR" });
            bookAnswer.Add(new Book { dewey = "156.259UYT" });
            bookAnswer.Add(new Book { dewey = "259.156OIP" });
            bookAnswer.Add(new Book { dewey = "356.15POU" });
            bookAnswer.Add(new Book { dewey = "356.157KDR" });
            bookAnswer.Add(new Book { dewey = "402.567BGH" });
            bookAnswer.Add(new Book { dewey = "402.567FTJ" });
            bookAnswer.Add(new Book { dewey = "458.268BFJ" });
            bookAnswer.Add(new Book { dewey = "536.458LGR" });
            bookAnswer.Add(new Book { dewey = "659.2IVD" });
            bookAnswer.Add(new Book { dewey = "856.124MJH" });
            bookAnswer.Add(new Book { dewey = "896.246UTR" });
            return bookAnswer;
        }

        //3
        public static List<Book> getBooks3()
        {
            List<Book> book = new List<Book>();

            book.Add(new Book { dewey = "659.256UYT" });
            book.Add(new Book { dewey = "356.36ZUT" });
            book.Add(new Book { dewey = "568.235LKJ" });
            book.Add(new Book { dewey = "154.21LHT" });
            book.Add(new Book { dewey = "698.458UYI" });
            book.Add(new Book { dewey = "356.365RTS" });
            book.Add(new Book { dewey = "259.869POU" });
            book.Add(new Book { dewey = "698.458UYT" });
            book.Add(new Book { dewey = "154.21KIT" });
            book.Add(new Book { dewey = "568.235LKI" });
            book.Add(new Book { dewey = "425.1LKH" });
            book.Add(new Book { dewey = "259.869TYI" });
            book.Add(new Book { dewey = "785.1JKL" });
            book.Add(new Book { dewey = "356.365POU" });
            book.Add(new Book { dewey = "425.259IUY" });
            book.Add(new Book { dewey = "154.21LHI" });
            book.Add(new Book { dewey = "568.23POU" });
            book.Add(new Book { dewey = "259.869TYU" });
            book.Add(new Book { dewey = "785.05IPR" });
            book.Add(new Book { dewey = "425.259OIU" });

            return book;
        }

        public static List<Book> getBookAnswer3()
        {
            List<Book> bookAnswer = new List<Book>();
            bookAnswer.Add(new Book { dewey = "154.21KIT" });
            bookAnswer.Add(new Book { dewey = "154.21LHI" });
            bookAnswer.Add(new Book { dewey = "154.21LHT" });
            bookAnswer.Add(new Book { dewey = "259.869POU" });
            bookAnswer.Add(new Book { dewey = "259.869TYI" });
            bookAnswer.Add(new Book { dewey = "259.869TYU" });
            bookAnswer.Add(new Book { dewey = "356.36ZUT" });
            bookAnswer.Add(new Book { dewey = "356.365POU" });
            bookAnswer.Add(new Book { dewey = "356.365RTS" });
            bookAnswer.Add(new Book { dewey = "425.1LKH" });
            bookAnswer.Add(new Book { dewey = "425.259IUY" });
            bookAnswer.Add(new Book { dewey = "425.259OIU" });
            bookAnswer.Add(new Book { dewey = "568.23POU" });
            bookAnswer.Add(new Book { dewey = "568.235LKI" });
            bookAnswer.Add(new Book { dewey = "568.235LKJ" });
            bookAnswer.Add(new Book { dewey = "659.256UYT" });
            bookAnswer.Add(new Book { dewey = "698.458UYI" });
            bookAnswer.Add(new Book { dewey = "698.458UYT" });
            bookAnswer.Add(new Book { dewey = "785.1JKL" });
            bookAnswer.Add(new Book { dewey = "785.05IPR" });

            return bookAnswer;
        }
    }
}
