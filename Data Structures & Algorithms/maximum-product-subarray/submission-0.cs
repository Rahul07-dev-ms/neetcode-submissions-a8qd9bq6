public class Solution {
    public int MaxProduct(int[] nums) {
        int presum = 1;
        int suff = 1;
        int ans = Int32.MinValue;
        for(int i=0; i<nums.Length; i++){
            presum*=nums[i];
            ans = Math.Max(ans,presum);
            if(nums[i]==0){
                presum = 1;
            }

        }
        for(int i=nums.Length-1; i>=0; i--){
            suff*=nums[i];
            ans = Math.Max(ans,suff);
            if(nums[i]==0){
                suff = 1;
            }
        }
        return ans;
    }
}