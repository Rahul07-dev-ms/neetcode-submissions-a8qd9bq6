public class Solution {
    public bool IsPalindrome(string s) {
        int low = 0;
        int high = s.Length - 1;
        while(low < high){
            char start = char.ToLower(s[low]);
            char end = char.ToLower(s[high]);
            if((start >= 'a' && start <= 'z')||(start >= '0' && start<= '9')){
                if((end >='a' && end <= 'z')||(end >= '0' && end <= '9')){
                    if(start != end){
                        return false;
                    }
                low++;
                high--;
                }
                else{
                    high--;
                }
            }
            else{
                low++;
            }
        }
        return true;
    }
}