int N = 1;
int M = 3;

int A(int M, int N)
{
    if (M == 0) 
    {
        return N + 1;
    }
    if (M > 0 && N == 0)
    {
        return A(M - 1, 1);
    }
    if (M > 0 && N > 0)
    {
        return A(M - 1, A(M, N - 1));
    }
    return A(M,N);
}
Console.WriteLine(A(M, N));