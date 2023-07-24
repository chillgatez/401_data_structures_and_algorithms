namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      //insert the value into the middle of the array

      int[] newArray = new int[array.Length + 1];
      int middleIndex = array.Length / 2;

      for (int i = 0; i < newArray.Length; i++)
      {
        if (i < middleIndex)
        {
          newArray[i] = array[i];
        }
        else if (i == middleIndex)
        {
          newArray[i] = value;
        }
        else
        {
          newArray[i] = array[i - 1];
        }
      }

      return newArray;
    }
  }
}
