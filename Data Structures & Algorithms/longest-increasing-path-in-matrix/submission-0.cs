public class Solution {
    private int bfs(int[][] matrix,int i,int j,int m,int n,int[,] vis){
        if(vis[i,j]!=-1) return vis[i,j];
        int res = 1;
        var row = new int[4]{0,1,0,-1};
        var col = new int[4]{1,0,-1,0};
        for(int k=0; k<4; k++){
            int r = i + row[k];
            int c = j + col[k];
            if(r>=0 && c>=0 && r<m && c<n && matrix[r][c] > matrix[i][j]){
                res = Math.Max(res,1 + bfs(matrix,r,c,m,n,vis));
            }
            
        }
        return vis[i,j] = res;
    }
    public int LongestIncreasingPath(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int ans = 0;
        int[,] vis = new int[m,n];
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                vis[i,j]=-1;
            }
        }
        for(int i=0; i<m;i++){
            for(int j=0; j<n; j++){
                ans = Math.Max(ans,bfs(matrix,i,j,m,n,vis));                
            }
        }
        return ans;
    }
}