namespace TugasArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hari = { "senin", "selasa", "rabu", "kamis", "jumat", "sabtu", "minggu"};
            Console.WriteLine("Masukkan angka, 1-10 : ");
            int days = Convert.ToInt32(Console.ReadLine());

            if (days == 1)
            {
                Console.WriteLine(hari[0]);
            }
            else if (days == 2)
            {
                Console.WriteLine(hari[1]);
            }
            else if (days == 3)
            {
                Console.WriteLine(hari[2]);
            }
            else if (days == 4)
            {
                Console.WriteLine(hari[3]);
            }
            else if (days == 5)
            {
                Console.WriteLine(hari[4]);
            }
            else if (days == 6)
            {
                Console.WriteLine(hari[5]);
            }
            else if (days == 7)
            {
                Console.WriteLine(hari[6]);
            }
            else
            {
                Console.WriteLine("Tidak ditemukan");
            }
            
            Console.WriteLine("Masukkan karakter ");
            char days1 = Convert.ToChar(Console.ReadLine());

            if (days1 == 'a')
            {
                Console.WriteLine(hari[0]);
            }
            else if (days1 == 'b')
            {
                Console.WriteLine(hari[1]);
            }
            else if (days1 == 'c')
            {
                Console.WriteLine(hari[2]);
            }
            else if (days1 == 'd')
            {
                Console.WriteLine(hari[3]);
            }
            else if (days1 == 'e')
            {
                Console.WriteLine(hari[4]);
            }
            else if (days1 == 'f')
            {
                Console.WriteLine(hari[5]);
            }
            else if (days1 == 'g')
            {
                Console.WriteLine(hari[6]);
            }
            else
            {
                Console.WriteLine("Tidak ditemukan");
            }
        }
       
    }
}