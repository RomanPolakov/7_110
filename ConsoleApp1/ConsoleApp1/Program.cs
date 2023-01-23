Console.WriteLine("Введите колличества целых чисел в цикле и число b, на которое делить сумму чисель массива");
int b = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
    sum = sum + arr[i];
}

if ((sum % b) == 0)
{
    Console.WriteLine("Сумма чисел в массиве кратна числу b");
}
else
{
    Console.WriteLine("Сумма чисел в массиве не кратна числу b");
}