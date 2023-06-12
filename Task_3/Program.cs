Console.Write("Input number=> ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = numberFirst *(-1);

while(numberSecond <=numberFirst){
    Console.Write($"{numberSecond} ");
    numberSecond +=1;
}



