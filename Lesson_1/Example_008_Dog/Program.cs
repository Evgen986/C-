int count = 0,
    distance = 10000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpped = 5,
    time;
bool friend = true;

while (distance>10){
    Console.WriteLine("Цикл № " + count);
    
    if (friend==false){
        time=distance/(firstFriendSpeed+dogSpped);
        friend=true;
    } else {
        time=distance/(secondFriendSpeed+dogSpped);
        friend=false;
    }
    
    distance=distance-(firstFriendSpeed+secondFriendSpeed)*time;
    Console.WriteLine("Дистанция составляет: " + distance);
    count++;
}

Console.WriteLine("Собака успеет пробежать " + count + " раз.");