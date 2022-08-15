public class Solution {
    private int[] index;

    private int[] temp;

    private int[] tempIndex;

    private int[] ans;

    public IList<int> CountSmaller(int[] nums) {
        this.index = new int[nums.Length];
        this.temp = new int[nums.Length];
        this.tempIndex = new int[nums.Length];
        this.ans = new int[nums.Length];

        for (int i = 0; i < nums.Length; ++i)
        {
            index[i] = i;
        }

        int l = 0, r = nums.Length - 1;
        MergeSort(nums, l, r);

        return new List<int>(ans);
    }

    public void Merge(int[] a, int l, int mid, int r)
    {
        int i = l, j = mid + 1, p = l;
        while (i <= mid && j <= r)
        {
            if (a[i] <= a[j])
            {
                temp[p] = a[i];
                tempIndex[p] = index[i];
                ans[index[i]] += (j - mid - 1);
                ++i;
                ++p;
            }
            else 
            {
                temp[p] = a[j];
                tempIndex[p] = index[j];
                ++j;
                ++p;
            }
        }

        while (i <= mid) 
        {
            temp[p] = a[i];
            tempIndex[p] = index[i];
            ans[index[i]] += (j - mid - 1);
            ++i;
            ++p;
        }

        while (j <= r)
        {
            temp[p] = a[j];
            tempIndex[p] = index[j];
            ++j;
            ++p;
        }

        for (int k = l; k <= r; ++k)
        {
            index[k] = tempIndex[k];
            a[k] = temp[k];
        }
    }

    public void MergeSort(int[] a, int l, int r)
    {
        if (l >= r) 
        {
            return;
        }

        int mid = (l + r) >> 1;
        MergeSort(a, l, mid);
        MergeSort(a, mid + 1, r);
        Merge(a, l, mid, r);
    }
}