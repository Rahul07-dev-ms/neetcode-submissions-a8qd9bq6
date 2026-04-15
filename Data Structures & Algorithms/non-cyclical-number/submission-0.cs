public class Solution {
    private int GetSum(int n){
        int sum = 0;
        while(n!=0){
            int val = n % 10;
            sum += (val*val);
            n = n / 10;
        }
        return sum;
    }
    public bool IsHappy(int n) {
        int slow = n;
        int fast = GetSum(n);
        while(fast != 1 && slow!=fast){
            slow = GetSum(slow);
            fast = GetSum(GetSum(fast));
        }
        return fast==1;
    }
}