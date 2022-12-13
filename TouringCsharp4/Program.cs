using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            double a = 0, b = 20, result;

            try
            {
                result = ExceptionTest.SafeDivision(a: a, b: b);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Tidak bisa menerima nol sebagai pembagi.");
                Console.WriteLine(ex.ToString());
                throw;

            }

            try
            {
                using (var sw = new StreamWriter("./text.txt"))
                {
                    sw.WriteLine("hallo");
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("done");
            FileStream file = null;
            FileInfo fileInfo = new FileInfo("./file.txt");
            try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                file.Close();
            }

            try
            {
                file = fileInfo.OpenWrite();
                Console.WriteLine("OpenWrite() success");
            }
            catch (IOException)
            {
                Console.WriteLine("OpenWrite() failed");
            }

            int[] array = { 1, 2, 3, 4, 5 };
            int index = array.Length;

            int getElementArray = GetInt(array: array, index: index);
            Console.WriteLine(getElementArray);
            */

        }

        private static void Valid(string param)
        {
            _ = param ?? throw new ArgumentException("Parameter tidak valid");
        }

        private static int GetInt(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (ArgumentOutOfRangeException e) when (index < 0)
            {
                throw new ArgumentOutOfRangeException("Parameter index cannot be negative", e);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //throw;
                throw new ArgumentOutOfRangeException("Parameter index is out of range", e);
            }
        }
    }
}
