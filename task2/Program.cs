//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] getPoint()
{
    int i = 0;
    int[] point = new int[3];
    while (i < 3)
    {
        point[i] = new Random().Next(-9, 10);
        i++;
    }
    return point;
}

string getPointDescription(int[] point)
{
    return $"({point[0]}, {point[1]}, {point[2]})";
}


void printDistance(int[] point1, int[] point2)
{
    int differenceX = point1[0] - point2[0];
    int differenceY = point1[1] - point2[1];
    int differenceZ = point1[2] - point2[2];
    double distance = Math.Sqrt(differenceX * differenceX + differenceY * differenceY + differenceZ * differenceZ);
    Console.Write($"Расстояние между точкой A {getPointDescription(point1)} и точкой B {getPointDescription(point2)} равно ");
    Console.WriteLine("{0:f2}", distance);
}
int[] A1 = { 3, 6, 8 };
int[] B1 = { 2, 1, -7 };
int[] A2 = { 7, -5, 0 };
int[] B2 = { 1, -1, 9 };
int[] A3 = getPoint();
int[] B3 = getPoint();
int[] A4 = getPoint();
int[] B4 = getPoint();
printDistance(A1, B1);
printDistance(A2, B2);
printDistance(A3, B3);
printDistance(A4, B4);
