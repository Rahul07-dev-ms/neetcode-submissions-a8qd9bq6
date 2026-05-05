public class Solution {

    public string Encode(IList<string> strs) {
        string res = "";
        foreach(string s in strs){
            res += s;
            res += '¥';
        }
        return res;
    }

    public List<string> Decode(string s) {
        var ans = new List<string>();
        int prev = 0;   
        for(int i=0; i<s.Length;i++){
            if(s[i] == '¥'){
                string key = s.Substring(prev,i-prev);
                prev = i+1;
                ans.Add(key);
            }
        }
        return ans;
   }
}
