public class DecrementIfLessThanFirst
{
    public static int[] decrementIfLessThanFirst(int[] arr)
    {
        if (arr != null && arr.Length > 0)
        {
            int _first = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < _first)
                {
                    --arr[i];
                }
            }
        }

        return arr;
    }
}
