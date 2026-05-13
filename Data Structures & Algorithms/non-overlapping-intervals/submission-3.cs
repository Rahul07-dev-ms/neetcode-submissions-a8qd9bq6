public class Solution {
    public int EraseOverlapIntervals(int[][] nums) {
        Array.Sort(nums,(a,b)=>a[1].CompareTo(b[1]));
        int ans = 0;
        int q = Int32.MinValue;
        foreach(var arr in nums){
            int x = arr[0];
            int y = arr[1];
            if (q > x){
                ans++;
            }
            else{
                q = y;
            }
        }
        return ans;
    }
}