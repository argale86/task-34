//найти кол-во чётных чисел в случайном массиве
Console.WriteLine("Введите кол-во элементов в массиве:");
int numbermas = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[numbermas];
Random rnd = new Random();
for (int count = 0; count < numbermas;count++)
{
    mas[count] = rnd.Next(0, 32654);
    //Console.WriteLine("Элемент массива номер" + count + " = " + mas[count]);
}
int chtn = 0;
for (int count = 0; count < numbermas;count++)
{
    if ((mas[count] % 2) == 0)
    {
        chtn++;
    }
}
Console.WriteLine("Количество чётных элементов массива = " + chtn);