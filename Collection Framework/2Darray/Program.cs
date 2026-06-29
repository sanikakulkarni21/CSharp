
// addition of 2d array

int[,]arr1 = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

int[,] arr2=
{
    {2,3,4},
    {5,6,8},
    {4,5,6}
};

int [,]result=new int[3,3];
for(int i=0;i<3;i++)
{
    for(int j = 0; j <3; j++)
    {
        result[i,j]=arr1[i,j]+arr2[i,j];
    }
}

for(int i = 0; i <3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.Write(result[i,j]+"\t ");
    }
    Console.WriteLine();
}