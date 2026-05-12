public class Solution {
    public int[][] Insert(int[][] intervals, int[] ni) {
        var ans = new List<int[]>();
        int p = ni[0], q = ni[1];

        foreach (var arr in intervals) {
            int x = arr[0], y = arr[1];

            if (y < p) {
                // interval completely before new one
                ans.Add(arr);
            } else if (x > q) {
                // interval completely after new one
                ans.Add(new int[]{p, q});
                p = x; q = y; // reset new interval to current
            } else {
                // overlap: merge
                p = Math.Min(p, x);
                q = Math.Max(q, y);
            }
        }

        ans.Add(new int[]{p, q});
        return ans.ToArray();
    }
}
