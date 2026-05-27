public class Solution {
    public List<int> PartitionLabels(string s) {
        var map = new Dictionary<char,(int,int)>();
        int idx = 0;
        foreach(char c in s){
            if(!map.ContainsKey(c)){
                map[c] = (idx,idx);
            }
            else{
                map[c] = (map[c].Item1,idx);
            }
            idx++;
        }
        var ans = new List<int>();
        int p = -1, q = -1;
        foreach(var pair in map){
            int x = pair.Value.Item1;
            int y = pair.Value.Item2;
            if(p==-1){
                p=x;
                q=y;
            }
            else if (q > x){
                q = Math.Max(q,y);
            }
            else{
                ans.Add(q-p+1);
                p=x;
                q=y;
            }
        }
        ans.Add(q-p+1);
        return ans;
    }
}