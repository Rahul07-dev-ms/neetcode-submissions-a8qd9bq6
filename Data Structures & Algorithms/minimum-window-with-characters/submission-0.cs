public class Solution {
    public string MinWindow(string s, string t) {
        int start=0, end=0, ans=Int32.MaxValue;
        var map = new Dictionary<char,int>();
        var temp = new Dictionary<char,int>();
        foreach(char c in t){
            if(!map.ContainsKey(c)) map[c]=1;
            else map[c]++;
        }
        int count = 0;
        string res = "";
        while(end < s.Length){
            if(map.ContainsKey(s[end])){
                if(!temp.ContainsKey(s[end])) temp[s[end]]=1;
                else temp[s[end]]++;
                if(temp[s[end]] == map[s[end]]) count++;
            }
            if(count == map.Count){
                while(count == map.Count){
                    if(res == "" || end-start+1 < res.Length){
                        res = s.Substring(start,end-start+1);
                    }
                    if(map.ContainsKey(s[start])){
                        temp[s[start]]--;
                        if(temp[s[start]] < map[s[start]]) count--;
                    }
                    start++;
                }
            }
            end++;
        }
        return res;
    }
}