int M = 456;
int N = 12;
int Natural(int M, int N)
{
  if (N == M)
  {
    return M;
  }
  Console.WriteLine(N);
  return Natural(M, N + 1);
}

Console.Write(Natural(M, N));