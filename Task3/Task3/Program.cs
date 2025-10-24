namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество шаров в коробке: ");

            int count = 0;
            try
            {
                count = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректное значение!");
                return;
            }

            int[] box = new int[count];


            for (int i = 0; i < count; i++)
            {
                box[i] = 0;
            }

            Random random = new Random();
            int index = random.Next(0, box.Length);
            box[index] = 1;

            for (int i = 0; i < count; i++)
            {
                Console.Write(box[i] + " ");
                if (box[i] == 1)
                {
                    Console.WriteLine("\nЧерный шар был найден с " + (i + 1) + " попытки.");
                    break;
                }
            }
        }
    }
}
