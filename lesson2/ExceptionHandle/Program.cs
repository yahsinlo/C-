using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            //catch (Exception e)  //會印出anyway,  it's OK+  123456
            catch (NullReferenceException e)  //印出anyway,  it's OK
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("anyway, it's OK");
            }
            Console.WriteLine("123456");
            //throw new NullReferenceException();

            var ae = new ArgumentException(); //參數異常
            var ane = new ArgumentNullException();//參數為空
            var aore = new ArgumentOutOfRangeException();//參數超出範圍
            var dne = new DirectoryNotFoundException(); //路徑異常
            var fne = new FileNotFoundException();//檔案找不到
            var ioe = new InvalidOperationException();//運算錯誤
            var nie = new NotImplementedException();//未實現異常

            if(true)
            {

            }
            try
            {
                throw new Exception();
            }
            catch(Exception e)
            {

            }

        }
    }
}
