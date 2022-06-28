namespace Coding_Challange.LeetCode.Algos.Binary_Search
{
    public class First_Bad_Version
    {
        Dictionary<int, bool> IsBadVersion = new Dictionary<int, bool>()
        {
            {1,false},
            {2,false},
            {3,false},
            {4,true},
            {5,true},
            {6,true}
        };
        public int FirstBadVersion(int n)
        {
            int start = 1, end = n;
            while (start <= end)
            {
                int pivot = start + (end - start) / 2;
                if (IsBadVersion[pivot])
                {
                    if (IsBadVersion[pivot - 1])
                    {
                        end = pivot - 1;
                        continue;
                    }
                    else
                        return pivot;
                }
                else
                    start = pivot + 1;
            }
            return -1;
        }
    }
}
