//Имеется одномерный массив array из n элементов,
//требуется найти элемет массива,равный find






int[] array ={10,22,17,37,42,45,66,17,82};

int n = array.Length;
int find = 17;

int index = 0;

while( index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}