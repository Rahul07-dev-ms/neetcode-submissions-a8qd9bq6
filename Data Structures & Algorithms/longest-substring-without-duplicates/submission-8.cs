public class Solution {
    private (bool,int) solve(Dictionary<char,int> map){
        int count = 0;
        foreach(var pair in map){
            if(pair.Value > 1)return (false,-1);
            count++;
        }
        return (true,count);
    }
    public int LengthOfLongestSubstring(string s) {
        var map = new Dictionary<char,int>();
        int i=0, j=0;
        int ans = 0;
        while(j < s.Length){
            if(!map.ContainsKey(s[j])){
                map[s[j]]=1;
            }
            else{
                map[s[j]]++;
            }
            (bool,int) check = solve(map);
            if(check.Item1){
                ans = Math.Max(ans,check.Item2);
            }
            else{
                map[s[i]]--;
                if(map[s[i]]==0) map.Remove(s[i]);
                i++;
            }
            j++;
        }
        return ans;
    }
}