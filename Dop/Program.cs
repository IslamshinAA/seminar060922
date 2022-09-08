Console.Clear();
Console.WriteLine("Введите интересующий вас количество дней: ");
int n = Convert.ToInt32(Console.ReadLine());
void Temper(int[] temperature)
{
    int lenght = temperature.Length;
    int i = 0;
    while(i < lenght)
    {
        temperature[i] = new Random().Next(-50,50);
        i++;
    }
    
}
int[] array = new int [100];
Temper(array);
int i = 0;
int day = 0;
if(i < n)
{

}

    
    }


// int positiveCount=array.Count(x=>x>0);
// Console.WriteLine();
// Console.WriteLine(positiveCount + "     ");