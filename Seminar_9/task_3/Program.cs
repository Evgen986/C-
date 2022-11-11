/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/

Main();


void Main(){
    Console.Clear();
    int n = 238;
    Console.WriteLine(SumNumbers(n));

}


int SumNumbers (int n){
    if(n == 0) return 0;
    else return n%10 + SumNumbers(n/10);
}