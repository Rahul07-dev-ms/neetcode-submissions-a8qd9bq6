public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int size = points.Length;
        var pq = new PriorityQueue<(int,int),int>();
        var vis = new bool[size];
        pq.Enqueue((0,0),0);
        int sum = 0;
        while(pq.Count != 0){
            var node = pq.Dequeue();
            if(vis[node.Item2]) continue;
            vis[node.Item2] = true;
            sum+=node.Item1;
            for(int v=0; v<size; v++){
                if(!vis[v]){
                    int wt = Math.Abs(points[node.Item2][0] - points[v][0]) + Math.Abs(points[node.Item2][1] - points[v][1]);
                    pq.Enqueue((wt,v),wt);
                }
            }
        }
        return sum;
    }    
}