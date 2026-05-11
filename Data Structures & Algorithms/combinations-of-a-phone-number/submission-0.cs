public class Solution {
    private void solve(List<string> ans,string s, int idx, Dictionary<char,string> map, string res){
        if(idx >= s.Length){
            ans.Add(res);
            return;
        }
        for(int i=0; i<map[s[idx]].Length; i++){
            res = res + map[s[idx]][i];
            solve(ans,s,idx+1,map,res);
            res = res.Substring(0,res.Length-1);
        }
    }
    public List<string> LetterCombinations(string digits) {
        var map = new Dictionary<char,string>{
            {'2',"abc"},{'3',"def"},{'4',"ghi"},{'5',"jkl"},{'6',"mno"}
            ,{'7',"pqrs"},{'8',"tuv"},{'9',"wxyz"}
        };
        var ans = new List<string>();
        if(digits.Length==0) return ans;
        solve(ans,digits,0,map,"");
        return ans;
    }
}