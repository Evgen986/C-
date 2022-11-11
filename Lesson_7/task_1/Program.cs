int a = 1;
int b = 10;

// Console.WriteLine(NumberRec(a,b));
int x = SumRec(8);
// Console.WriteLine(x);

char [] s = {'а', 'и', 'с', 'в'};

int count = s.Length;
int n=1;

for (int i = 0; i< count; i++){
    Console.WriteLine($"{n++, -5}{s[i]}");
}

void WordRec (char[]array){
    
}

string NumberRec (int a, int b){
    if (a<b) return NumberRec(a+1, b) + $"{a} ";
    else return $"{b}";
}

int SumRec (int n){
    if ( n == 0 ) return 0;
    else return n+SumRec(n-1);
}
