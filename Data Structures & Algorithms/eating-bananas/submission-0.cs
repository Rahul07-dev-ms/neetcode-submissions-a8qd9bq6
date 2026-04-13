public class Solution {
    private bool check(int[] arr, int idx, int h){
        int hours = 0;
        foreach(var e in arr){
            int val = e;
            int rem = val/idx;
            hours = hours + rem;
            int carry = val % idx;
            if(carry != 0) hours++;
        }
        return hours <= h;
    }
    public int MinEatingSpeed(int[] piles, int h) {
        int low = 1;
        int high = piles.Max();
        while(low < high){
            int mid = low + (high-low)/2;
            if(check(piles,mid,h)){
                high = mid;
            }
            else{
                low = mid+1;
            }
        }
        return low;
    }
}