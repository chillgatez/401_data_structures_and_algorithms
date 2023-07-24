namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
    {
      if (nthNumberInSequence <= 0)
      {
        throw new Exception("Input must be a posiive integer.");
      }
      if (nthNumberInSequence == 1)
      {
        return 0;
      }
      if (nthNumberInSequence == 2)
      {
        return 1;
      }


      return GetNthNumberInFibonacciSequence(nthNumberInSequence - 1) + GetNthNumberInFibonacciSequence(nthNumberInSequence - 2);
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
