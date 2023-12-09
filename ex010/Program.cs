int[] array ={11,52,25,52,7,58,98,44,52,32,55,98,85,147};

int n = array.Length;
int find = 52;

int index = 0;

while(index< n)
{
    if(array[index] ==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

