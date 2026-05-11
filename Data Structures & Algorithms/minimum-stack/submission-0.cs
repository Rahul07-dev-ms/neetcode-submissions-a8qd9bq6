public class MinStack {
    private Stack<int> st1;
    private Stack<int> st2;
    public MinStack() {
        st1 = new();
        st2 = new();
    }
    
    public void Push(int val) {
        st1.Push(val);
        if(st2.Count == 0 || st2.Peek() >= val){
            st2.Push(val);
        }
    }
    
    public void Pop() {
        int v = st1.Pop();
        if(v == st2.Peek()) st2.Pop();
    }
    
    public int Top() {
        return st1.Peek();
    }
    
    public int GetMin() {
        return st2.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */