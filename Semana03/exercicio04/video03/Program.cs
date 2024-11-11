int[] myarray = new int[6];
int lenght = 0;

for (int i = 0; i < 3; i++)
{
    myarray[lenght] = i+1;
    lenght++;
}

//myarray[lenght] = 8;
//lenght++;

for (int i = 3; i >=0; i++)
{
    myarray[i+1] = myarray[i];
}
myarray[0] = 8;