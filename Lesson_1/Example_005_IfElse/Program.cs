Console.Write("Введите ваше имя: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша"){
    Console.WriteLine("Ура! Это же МАША!!!");
} else {
    Console.WriteLine("Привет " + userName + "!");
}