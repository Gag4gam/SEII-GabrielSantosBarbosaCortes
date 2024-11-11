int[] intarray = new int[]{1,2,3,4,5,6,7,8,9};

bool linearsearch (int[] array,int key)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == key){

            return true;

        }
    }

    return false;
}
Console.WriteLine(linearsearch(intarray,33));
