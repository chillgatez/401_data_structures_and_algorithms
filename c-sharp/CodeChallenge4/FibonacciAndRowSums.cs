namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
    {
      int result = 0;

      return result;
    }

    public static int[] RowSums(int[][] matrix)
    {
      int rows = matrix.Length;
      int[] rowSums = new int[rows];

      if (rows <= 0)
      {
        return new int[0];
      }

      for (int i = 0; i < rows; i++)
      {
        for (int x = 0; x < matrix[i].Length; x++)
        {
          rowSums[i] += matrix[i][x];
        }
      }

      return rowSums;
    }
  }

}
