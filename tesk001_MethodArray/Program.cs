// Поиск позиции нужного нам елемента
Console.Clear();
int[] array = {51, 32, 73, 51, 15, 326, 51, 788, 29};

int n = array.Length;
int find = 51;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {   
        Console.WriteLine(index);
        break;
    }
    index++;
    
}
