public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum = Int32.MinValue;
        int temp = 0;
        foreach(int i in nums){
            temp+=i;
            if(sum < temp){
                sum = temp;
            }
            if(temp < 0){
                temp = 0;
            }
        }
        return sum;
    }
}
