// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// ______

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// int count = 0;

// for (int i=0; i<size; i++)
// {
//     array[i]= new Random().Next (100,1000);
//     if (array[i]%2 == 0)
//     {
//         count++;
//     }
    
// }
// Console.Write("[{0}]",string.Join(", ",array));
// Console.Write(" -> "+ count);


//--------------------------------------------------------------------------
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
// _________


// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// int sum = 0;

// for (int i=0; i<size; i++)
// {
//     array[i]= new Random().Next ();
//     if (i%2 != 0)
//     {
//         sum+=array[i];
//     }
    
// }
// Console.Write("[{0}]",string.Join(", ",array));
// Console.Write(" -> "+ sum);

//--------------------------------------------------------------------------------
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// _______


Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double [size];
double diff = 0;
array[0]= new Random().Next ();
double min = array[0];
double max = min;

for (int i=1; i<size; i++)
{
    array[i]= new Random().Next ();
    if (array[i] < min)
    {
        min=array[i];
    }
    else
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    
}
diff = max - min;
Console.Write("[{0}]",string.Join(", ",array));
Console.Write(" -> "+ diff);