/* Напишите метод который будет отсортировывать массив от макисмального к минимальному
*/
int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void printArray(int [] array){
    Console.Write("[ ");
    for (int i = 0; i<array.Length; i++){
        if(i == array.Length-1){
        Console.Write(array[i] + " ]");    
        }else
        Console.Write( array[i] + ", ");
    }
}

void SortArrayMax (int [] array){
    for(int i =0; i<array.Length -1; i++){
        int maximal = i;
            for(int j=i+1; j<array.Length; j++)
            {
                if(array[j]>array[maximal]){
                    maximal = j;
                }
            }
        int temp = array[i];
        array[i] = array[maximal];
        array[maximal] = temp;
    }
}
SortArrayMax(array);
printArray(array);