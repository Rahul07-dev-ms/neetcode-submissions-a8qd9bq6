public class Solution {
    public int MissingNumber(int[] nums) {
        int idx = 1;
        int ans = 0;
        for(int i=0; i<nums.Length;i++){
            ans = ans ^ nums[i] ^ idx;
            idx++; 
        }
        return ans;
    }
}