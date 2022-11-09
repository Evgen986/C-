/*Задача 55: Задайте двумерный массив. Напишите программу, 
             которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
Main();

void Main(){
    Console.Clear();
    int [,] array = GetArray(4,3);
    PrintArray(array);
    Console.WriteLine();
    int [,] array2 = ReversRowsColumns(array);
    PrintArray(array2);

}

int [,] GetArray (int sizeRows, int sizeColumns){
    int [,] array = new int [sizeRows, sizeColumns];
    for (int i=0; i<array.GetLength(0); i++){
        for (int j = 0; j<array.GetLength(1); j++){
            array [i,j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void PrintArray (int [,] array){
    for (int i=0; i<array.GetLength(0); i++){
        for (int j = 0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
    }
}

int [,] ReversRowsColumns (int [,] array){
    try{
    int [,] array2 = array;
    for (int i = 0; i<array.GetLength(0); i++){
        for (int j = 0; j<array.GetLength(1); j++){
        int temp = array2[i,j];
        array2[i,j] = array2[j,i];
        array2[j,i] = temp;
    }
    }
    return array2;
    } catch(System.IndexOutOfRangeException){
        Console.WriteLine("Операция не выполнима");
        return array;
    }
}