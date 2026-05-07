public class Solution {
    public int[] DailyTemperatures(int[] t) {
        var st = new Stack<(int,int)>();
        int[] ans = new int[t.Length];
        for(int i=t.Length-1;i>=0;i--){
            if(st.Count == 0){
                ans[i] = 0;
            }
            else{
                while(st.Count > 0 && st.Peek().Item1 <= t[i]){
                    st.Pop();
                }
                if(st.Count==0){
                    ans[i]=0;
                }
                else{
                    ans[i] = st.Peek().Item2 - i;
                }
            }
            st.Push((t[i],i));
        }
        return ans;
    }
}