namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] numbers, int value)
    {
      // Insert the value into the middle of the array
      int[] newArray = new int[numbers.Length + 1];
      int middleIndex = numbers.Length / 2;

      for (int i = 0; i < newArray.Length; i++)
      {
        if (i < middleIndex)
        {
          newArray[i] = numbers[i];
        }
        else if (i == middleIndex)
        {
          newArray[i] = value;
        }
        else
        {
          newArray[i] = numbers[i - 1];
        }
      }

      return newArray;
    }
  }
}
