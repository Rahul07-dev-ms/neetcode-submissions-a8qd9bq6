public class Solution {
    public int EraseOverlapIntervals(int[][] nums) {
        Array.Sort(nums,(a,b)=>a[1].CompareTo(b[1]));
        int ans = 0;
        int p = -1, q = -1;
        foreach(var arr in nums){
            int x = arr[0];
            int y = arr[1];
            if(p== -1){
                p = x;
                q = y;
            }
            else if (q > x){
                //q = Math.Max(y,q);
                ans++;
            }
            else{
                p = x;
                q = y;
            }
        }
        return ans;
    }
}