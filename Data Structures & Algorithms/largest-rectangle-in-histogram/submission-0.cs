public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var st = new Stack<int>();
        var left = new int[heights.Length];
        var rig = new int[heights.Length];
        //NSL
        for (int i=0; i<heights.Length ; i++){
            if (st.Count == 0){
                left[i]=-1;
            }
            else if (heights[i] > heights[st.Peek()]){
                left[i]=st.Peek();
            }
            else if ((st.Count!=0) && (heights[i] <= heights[st.Peek()])){
                while ((st.Count!=0) && (heights[i] <= heights[st.Peek()])){ 
                    st.Pop();
                }
                if (st.Count==0){
                    left[i]=-1;
                }
                else {
                    left[i]=st.Peek();
                }
            }
            st.Push(i);
        }
        st.Clear();
        //NSR
        for (int j=heights.Length-1; j>=0 ; j--){
            if (st.Count == 0){
                rig[j]=heights.Length;
            }
            else if (heights[j] > heights[st.Peek()]){
                rig[j]=st.Peek();
            }
            else if ((st.Count!=0) && (heights[j] <= heights[st.Peek()])){
                while ((st.Count!=0) && (heights[j] <= heights[st.Peek()])){
                    st.Pop();
                }
                if (st.Count==0){
                    rig[j]=heights.Length;
                }
                else {
                    rig[j]=st.Peek();
                }
            }
            st.Push(j);
        }
        for (int i=0 ; i<heights.Length; i++){
            left[i]=rig[i]-left[i]-1;
            left[i]=left[i] * heights[i];
        }
        return left.Max();

    }
}