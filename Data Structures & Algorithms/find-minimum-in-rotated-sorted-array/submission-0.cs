public class Solution {
    public int FindMin(int[] nums) {
        int low = 0;
        int high = nums.Length-1;
        int mid=0;
        while(low<high){
            mid = low + (high-low)/2;
            if(nums[low] <= nums[mid]){
                if(nums[low] > nums[high]){
                    low=mid+1;
                }
                else{
                    high=mid-1;
                }
            }
            else{
                if(nums[mid] <= nums[high]){
                    high=mid;
                }
                else{
                    low=mid;
                }
            }
        }
        return nums[low];
    }
}