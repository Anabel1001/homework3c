//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int[] number){
  int counter = 0;
  int length = number.Length;
  while (counter <  length){
    number[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArray(int[] mass){
  int count = mass.Length;
      for(int index = 0; index < count; index++)
    {
    System.Console.Write(mass[index]+ " ");
     }
}
int[] array = new int[number+1];
Cube(array);
PrintArray(array);