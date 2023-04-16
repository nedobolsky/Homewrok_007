// Задача №47
// int UserMatrix(string text){
//     Console.Write($"Введите значение {text} ");
//     int tmp = Convert.ToInt32(Console.ReadLine());
//     return tmp;
// }

// int matrixM = UserMatrix("M");
// int matrixN = UserMatrix("N");

// int [,] MatrixRandom(int m, int n){
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return matrix;
// }
// int[,] matrix = MatrixRandom(matrixM, matrixN);

// void PrintMatrix(){
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }
// PrintMatrix();

// Задача №50
// int UserMatrix(string text){
//     Console.Write($"Введите значение {text} ");
//     int tmp = Convert.ToInt32(Console.ReadLine());
//     return tmp;
// }

// int matrixM = UserMatrix("M");
// int matrixN = UserMatrix("N");
// int numberSearch = UserMatrix("искомое");

// int [,] MatrixRandom(int m, int n){
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(10);
//         }
//     }
//     return matrix;
// }
// int[,] matrix = MatrixRandom(matrixM, matrixN);

// void PrintMatrix(){
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }
// void MatrixSearch(){
//     int tmp = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if(tmp == 1){
//             break;
//         }
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j] == numberSearch){
//                 Console.WriteLine($"Координаты значения {(i,j)}");
//                 tmp = 1;
//                 break;
//             }
//         }
        
//     }

// }

// PrintMatrix();
// MatrixSearch();

// Задача №52
int UserMatrix(string text){
    Console.Write($"Введите значение {text} ");
    int tmp = Convert.ToInt32(Console.ReadLine());
    return tmp;
}

int matrixM = UserMatrix("M");
int matrixN = UserMatrix("N");

int [,] MatrixRandom(int m, int n){
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}
int[,] matrix = MatrixRandom(matrixM, matrixN);

void PrintMatrix(){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
void AverageNumberMatrix(){
    double tmp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            tmp += matrix[j, i];  
        }
        Console.WriteLine(Math.Round((tmp/matrixM), 2));
        tmp = 0;
    }
}
PrintMatrix();
AverageNumberMatrix();