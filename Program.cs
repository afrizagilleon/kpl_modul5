
namespace modul5_103022300154
{
    class Program
    {
        public static void Main()
        {
            PemrosesData pd = new PemrosesData();

            double maxVal = pd.DapatkanNilaiTerbesar<double>(10.0, 30.2, 22.1);
            Console.WriteLine($"Nilai Max: {maxVal}" );
        }
    }
     class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic max = a;
            if( (dynamic) b > max)
            {
                max = b;
            }
            
            if((dynamic) c > max)
            {
                max = c;
            }
            return max;
        }
    }
}