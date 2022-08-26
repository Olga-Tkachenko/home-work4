//напишите программу, которая задает массив из 8 элементов и выводит их на экран.
//например: 1,2,5,7,19 - [1,2,5,7,19]

int[] createArray()
{
    var random=new Random();
    var result=new int[8];
    for(long i=0; i<result.Length; i++)
    {
        result[i]=random.Next(0,100);
    } 
    return result;
}

var array=createArray();

for(var i=0; i<array.Length; i++)
Console.Write(array[i] + ", ");




