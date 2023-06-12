Console.Write("Input number day => ");
int numberDay = Convert.ToInt32(Console.ReadLine());
Dictionary<int, string> map = new Dictionary<int, string>(){
    {
        1, "Monday"
    },
    {
        2, "Tuesday "
    },
    {
        3, "Wednesday"
    },
    {
        4, "Thursday"
    },
    {
        5, "Friday"
    },
    {
        6,"Saturday "
    },
    {
        7, "Sunday"
    }
};

if(numberDay > 0 && numberDay < 8){
Console.WriteLine(map[numberDay]);
}
else{
    Console.WriteLine("There is no such day of the week");
}