
int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 1,2,3 };
jaggedArray[1] = new int[] { 1,2,2};

jaggedArray = JagArray.AddElement(jaggedArray,1, 7);



for(var i=0;i<jaggedArray.Length;i++)
{
    for(var j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
public class JagArray
{
    

    public static int[][] AddElement(int[][] array,int index, int element)
    {
        List<int> ArrayTolist = array[index].ToList<int>();
        var d = ArrayTolist.Append(element);
        array[index] = d.ToArray();
        return array;
    }
   
}
































/*

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 31 };
jaggedArray[1] = new int[] { 28, 29 };
var d = new s(jaggedArray);
jaggedArray = s.AddElement(1, 7);
int j = 0;
foreach (var item in jaggedArray)
{
    foreach (var i in item)
        Console.WriteLine(i);
    j++;
}
Console.WriteLine(j);
public class s
{
    private static int[][] Arrays;
    public s(int[][] arr)
    {
        Arrays = arr;
    }

    public static int[][] AddElement(int a, int b)
    {
        List<int> ArrayTolist = Arrays[a].ToList<int>();
        var d = ArrayTolist.Append(b);
        Arrays[a] = d.ToArray();
        return Arrays;
    }
    
}

*/