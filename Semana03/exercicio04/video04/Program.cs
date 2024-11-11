int[] intarray = new int[9];
int length =0;
for (int i = 0; i < 6; i++)
{
    intarray[length] = i+1;

    length++;
}
for (int i = 4; i < length; i++)
{
    intarray[i-1] = intarray[i];
}
//length--;
//for (int i = 1; i < length; i++)
//{
//    intarray[i-1]=intarray[i];
    
//}
length--;

for (int i = 0; i < length; i++)
{
    Console.WriteLine(intarray[i]);
}