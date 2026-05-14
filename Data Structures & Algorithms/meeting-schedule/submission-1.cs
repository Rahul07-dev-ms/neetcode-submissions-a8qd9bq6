/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> nums) {
        var list = nums.OrderBy(x=>x.end);
        int p = -1, q = -1; 
        foreach(var arr in list){
            int x = arr.start;
            int y = arr.end;
            if(x < q){
                return false;
            }
            else{
                p=x;
                q=y;
            }
        }
        return true;
    }
}
