public class MedianFinder {
    private PriorityQueue<int,int> minheap;
    private PriorityQueue<int,int> maxheap; 
    public MedianFinder() {
        minheap = new();
        maxheap = new();
    }
    
    public void AddNum(int num) {
        if(maxheap.Count==0 || maxheap.Peek()>num){
            maxheap.Enqueue(num,-num);
        }
        else{
            minheap.Enqueue(num,num);
        }
        while(minheap.Count > maxheap.Count+1){
            int val = minheap.Dequeue();
            maxheap.Enqueue(val,-val);
        }
        while(maxheap.Count > minheap.Count+1){
            int val = maxheap.Dequeue();
            minheap.Enqueue(val,val);
        }
    }
    
    public double FindMedian() {
        double ans = 0;
        if(minheap.Count == maxheap.Count){
            ans = (double)(minheap.Peek() + maxheap.Peek())/2;
        }
        else if(minheap.Count > maxheap.Count){
            ans = minheap.Peek();
        }
        else{
            ans = maxheap.Peek();
        }
        return ans;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */