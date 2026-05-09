
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var hs = new HashSet<string>();
        foreach(string s in wordList){
            hs.Add(s);
        }
        var q= new Queue<(string,int)>();
        q.Enqueue((beginWord,1));
        while(q.Count != 0){
            var node = q.Dequeue();
            string st = node.Item1;
            int dist = node.Item2;
            if(st == endWord) return dist;
            for(int i=0; i<st.Length; i++){
                for(char c = 'a'; c<='z'; c++){
                    if(c == st[i]) continue;
                    string res = st.Substring(0,i) + c + st.Substring(i+1);
                    if(hs.Contains(res)){
                        hs.Remove(res);
                        q.Enqueue((res,dist+1));
                    }
                }
            }    
    }
    
        return 0;
}
}