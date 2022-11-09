/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/
Main();

void Main(){
    Console.Clear();
    int [,] array = GetArray(4,4);
    PrintArray(array);
    ReversRows(array);
    Console.WriteLine();
    PrintArray(array);

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

void ReversRows (int [,] array){
    for (int i = 0; i<array.GetLength(0); i++){
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
}