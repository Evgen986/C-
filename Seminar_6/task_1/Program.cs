/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
              [1 2 3 4 5] -> [5 4 3 2 1]
              [6 7 3 6] -> [6 3 7 6]
*/
Console.Clear();

int [] array = GetArray(5, 1, 11);
PrintArray(array);
Console.WriteLine("Получил массив");
// ReversArray(array);
// PrintArray(array);
// Console.WriteLine("Развернул массив");
int [] array2 = ReversArrayNewArray(array);
PrintArray(array2);
Console.WriteLine("Получил новый массив");

int [] GetArray (int sizeArray, int minValue, int maxValue){
    int [] arr = new int [sizeArray];
    for (int i = 0; i<sizeArray; i++){
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
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

void ReversArray (int [] arr){
   for(int i = 0; i<arr.Length/2; i++){
    int temp = arr[i];
    arr[i] = arr[arr.Length-1-i];
    arr[arr.Length-1-i] = temp;
   } 
}

int [] ReversArrayNewArray (int [] arr){
   int [] result = new int[arr.Length];
   for(int i = 0; i<arr.Length; i++){
    result[i] = arr[arr.Length-1-i];
    }
    return result;
}