public class Solution {
    public string Encode(IList<string> strs) {
        var s = new StringBuilder("");
        foreach(string st in strs){
            s.Append(st.Length);
            s.Append("#");
            s.Append(st);
        }
        return s.ToString();
    }
//5#hello5#world
    public List<string> Decode(string s) {
        int start = 0;
        var ans = new List<string>();
        while(start < s.Length){
            string l = "";
            while(s[start] != '#'){
                l =l + s[start++];
            }
            int len = Convert.ToInt32(l);
            start++;
            string op ="";
            op = s.Substring(start,len);
            start = start + len;
            ans.Add(op);
        }
        return ans;
   }
}
