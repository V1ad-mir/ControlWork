string[] InputArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("Введите "+i+"й элемент(строку) массива");
      array[i]=Console.ReadLine();
    }
  return array;
}

string[] OutputArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i]+" ");
    }
  return array;
}

Console.WriteLine("Длинну массива");
int linght=Convert.ToInt32(Console.ReadLine());
string [] arrayIn =new string [linght];
string [] arrayOut =new string [linght];
int num=3;                                            //по условию задачи 
int count=0;

InputArray(arrayIn);

for (int index = 0; index < arrayIn.Length; index++)
{
  if (arrayIn[index].Length<=num)
  {
    arrayOut[count]=arrayIn[index];
    count++;
  }
}
Console.WriteLine("Заданный массив");
 OutputArray(arrayIn);
 Console.WriteLine();
Console.WriteLine("Обработанный массив");
 OutputArray(arrayOut);