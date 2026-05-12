public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));
        var ans = new List<int[]>();
        int p = -1, q = -1;
        foreach(var arr in intervals){
            int x = arr[0];
            int y = arr[1];
            if(p==-1){
                p=x;
                q=y;
            }
            else if(q >= x){
                q = Math.Max(q,y);
            }
            else{
                ans.Add(new int[]{p,q});
                p=x;
                q=y;
            }
        }
        ans.Add(new int[] {p,q});
        return ans.ToArray();
    }
}