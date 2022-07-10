// See https://aka.ms/new-console-template for more information
double[] line = new double[100];
Console.Write("Vavedete broq okrajnosti K: ");
int k = int.Parse(Console.ReadLine());

for (int i = 0; i < k; i++)
{
    Console.Write("Vavedete mqstoto: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Vavedete radiusa na okryjnostta s center tova mqsto: ");
    int r = int.Parse(Console.ReadLine());
    line[m] = r;
}

// 3 места
Console.Write("Vavedete 3 mesta: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

// Проверка за всяка точка дали записания в нея радиус стига до горепосочните индекси


int numberOfCircles = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] - i >= x )
    {
        numberOfCircles++;
    }

    if (line[i] - i >= y)
    {
        numberOfCircles++;
    }

    if (line[i] - i >= z)
    {
        numberOfCircles++;
    }
}

int numberOfCommonCircles = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] - i >= x && line[i] - i >= y && line[i] - i >= z)
    {
        numberOfCommonCircles++;
    }
}

Console.WriteLine("Trite to4ki popadat v общ broi okryvnosti: " + numberOfCircles);
Console.WriteLine("Trite to4ki zaedno popadat v broi okryvnosti: " + numberOfCommonCircles);