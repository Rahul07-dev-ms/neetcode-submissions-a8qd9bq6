public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        foreach(char c in s){
            if(c == '(' || c == '[' || c == '{'){
                st.Push(c);
            }
            else if(st.Count != 0 && c == ']'){
                if(st.Pop() != '['){
                    return false;
                }
            }
            else if(st.Count != 0 && c == '}'){
                if(st.Pop() != '{'){
                    return false;
                }
            }
            else if(st.Count != 0 && c == ')'){
               if(st.Pop() != '('){
                    return false;
                } 
            }
            else return false;
        }
        return st.Count == 0;
    }
}