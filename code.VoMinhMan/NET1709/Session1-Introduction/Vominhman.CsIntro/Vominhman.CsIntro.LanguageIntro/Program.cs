namespace Vominhman.CsIntro.LanguageIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntergers();
        }

        static void PlayWithIntergers() 
        {
            long a = 1;
            int b = 3;
            
            Console.WriteLine("a has value of" + a);
            Console.WriteLine("b has value of" + b);//truyền thống

            Console.WriteLine("a has value of {0}", a);
            Console.WriteLine("b has value of {0}", b);
            Console.WriteLine("a nd b have value of {0} {1}", a, b);

            //interpolation - in theo kiểu nội quy
            Console.WriteLine($"a has value of {a}");

            
            var c = 69;
            Console.WriteLine($"c has value of {c}");
            //khai báo biến mà ngầm định kiểu dữ liệu implicit
            //như vậy kiểu dữ liệu sẽ dc xác định khi ta gắn value cho biến
            //và bắt buộc phải gán ngay lúc khai báo

            //kiểm tra data type của biến này là gì
            Console.WriteLine("the data type of a variable is" + a.GetType().ToString());
            Console.WriteLine("the data type of c variable is" + c.GetType().ToString());
        }
    }
}