public class Solution {
    public int MaxProfit(int[] nums) {
        int prev = nums[0];
        int maxi = 0;
        for(int i=1; i<nums.Length; i++){
            if(nums[i] < prev){
                prev = nums[i];
            }
            else{
                maxi = Math.Max(maxi,nums[i]-prev);
            }
        }
        return maxi;
    }
}