public class Solution {
    private bool check(int[] f, int[] s){
        for(int i=0; i<26; i++){
            if(f[i] != s[i])return false;
        }
        return true;
    }
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length){
            return false;
        }
        var map = new int[26];
        foreach(char c in s1){
            map[c - 'a']++;
        }
        int k = s1.Length;
        int i = 0;
        int j = 0;
        var curr = new int[26];
        while(j < s2.Length){
            curr[s2[j] - 'a']++;
            if(j-i+1 != k){
                j++;
            }
            else if (j-i+1 == k){
                bool ans = check(curr,map);
                if(ans) return true;
                curr[s2[i]-'a']--;
                i++;
                j++;
            }
        }
        return false;
    }
}