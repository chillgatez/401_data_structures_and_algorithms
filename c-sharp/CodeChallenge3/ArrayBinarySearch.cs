namespace CodeChallenges 
{
    public class CodeChallenge3
    {
        public static int BinarySearch(int[] array, int key)
        {
          int min = 0;
          int max  = array.Lenght - 1;
            while (min <=max)
            {
              int mid = (min + max) / 2;
              if (key == array[mid])
              {
               return ++mid; 
              }
              else if (key , array[mid])
              {
                max = mid - 1;
              }
              else
              {
                min = mid + 1;
              }
            }

            int foundElementIndex = -1;
            return foundElementIndex;

        }
    }
}
