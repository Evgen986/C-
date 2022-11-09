/* Задача 57: Составить частотный словарь элементов двумерного массива. 
              Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
              { 1, 9, 9, 0, 2, 8, 0, 9 }
                0 встречается 2 раза 
                1 встречается 1 раз 
                2 встречается 1 раз 
                8 встречается 1 раз 
                9 встречается 3 раза
                1, 2, 3 
                4, 6, 1 
                2, 1, 6
                1 встречается 3 раза 
                2 встречается 2 раз 
                3 встречается 1 раз 
                4 встречается 1 раз 
                6 встречается 2 раза
*/
Main();

void Main(){
    Console.Clear();
    int [,] array = GetArray(4,4);
    PrintArray(array);
    Console.WriteLine();
    CountNubers(array);
    

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

void CountNubers (int [,] array)
{
    int count = 0;
    int min = array[0,0];
    int max = array[0,0];
        for (int i=0; i<array.GetLength(0); i++){
        for (int j = 0; j<array.GetLength(1); j++){
            if(array [i,j] < min) min = array [i,j];
        }
        }
        for (int i=0; i<array.GetLength(0); i++){
        for (int j = 0; j<array.GetLength(1); j++){
            if(array [i,j] > max) max = array [i,j];
        }
        }
    while (max >= min){
    for (int i=0; i<array.GetLength(0); i++){
    for (int j = 0; j<array.GetLength(1); j++){
        if(array [i,j] == max) count++;
    }
    }
    Console.Write($"Число {max} встречается {count} раз");
    Console.WriteLine();
    count = 0;
    max--;
    }
}