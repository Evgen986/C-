// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

int [] array = new int [8];
RandomArray(array);

void RandomArray (int [] array){
    Console.Write("[ ");
    for (int i=0;i<array.Length; i++){
        array[i] = new Random().Next(0, 2);
        if(i< array.Length-1)
        {
            Console.Write(array[i] + ", ");
        }else{
            Console.Write(array[i] + " ]");
        }
    }
}