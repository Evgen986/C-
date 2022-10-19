// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

Main();

void Main()
{
int [] arr1 = GetArray(5, 1, 11);
PrintArray(arr1);
int [] arr2 = CopyArray(arr1);
PrintArray(arr2);
}


int [] CopyArray (int [] arr){
    int [] array = new int [arr.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

void PrintArray (int [] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++){
        if (i < arr.Length-1){
            Console.Write(arr[i] + ", ");
        }else{
            Console.Write(arr[i] + "]");
        }        
}
    Console.WriteLine();
}

int [] GetArray (int sizeArray, int minValue, int maxValue){
    int [] arr = new int [sizeArray];
    for (int i = 0; i<sizeArray; i++){
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}
