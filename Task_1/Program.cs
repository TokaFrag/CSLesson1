Console.Write("Input first number=> ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number=> ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
int squareNumber = numberFirst / numberSecond;
if(squareNumber == numberSecond){
    Console.WriteLine($"{numberFirst} is square {numberSecond}");
}
else{
Console.WriteLine($"{numberFirst} is not square {numberSecond}");
}
