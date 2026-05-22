public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 0;
        for(int i=digits.Length-1; i>=0; i--){
            int dig = digits[i];
            dig = dig + carry;
            if(i == digits.Length-1) dig+=1;
            digits[i] = dig % 10;
            carry = dig / 10;
            if(carry == 0){
                return digits;
            }
        }
        if(carry != 0){
            var ans = new int[digits.Length+1];
            ans[0]=carry;
            for(int i=0; i<digits.Length;i++){
                ans[i+1]=digits[i];
            }
            return ans;
        }
        return digits;
    }
}