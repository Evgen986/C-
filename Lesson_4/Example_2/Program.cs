 int GetFactorial (int n){
    if( n == 1) return 1;
    else return n * GetFactorial(n-1);
} 