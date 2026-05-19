public class Solution {
    public int CharacterReplacement(string s, int k) {
        var arr = new int[26];
        int ans = 0, st = 0, e = 0, maxi = 0;
        while(e < s.Length){
            arr[s[e]-'A']++;
            maxi = Math.Max(maxi,arr[s[e]-'A']);
            int changes = (e-st+1) - maxi;
            if(changes > k){
                while(((e-st+1)-maxi) > k){
                    arr[s[st]-'A']--;
                    st++;
                }
            }
            ans = Math.Max(ans,e-st+1);
            e++;
        }
        return ans;
    }
}
