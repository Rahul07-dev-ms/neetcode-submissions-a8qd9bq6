public class Solution {
    private static int[] row = new int[4]{0,1,0,-1};
    private static int[] col = new int[4]{1,0,-1,0};
    private bool find(char[][] b, int r, int c, int idx, string word,bool[,] vis,int m, int n){
        if(idx == word.Length){
            return true;
        }
        vis[r,c]=true;
        for(int i=0; i<4; i++){
            int n_r = row[i] + r;
            int n_c = col[i] + c;
            if(n_r>=0 && n_r <m && n_c >=0 && n_c <n && b[n_r][n_c] == word[idx] && !vis[n_r,n_c]){
                bool ans = false;
                if(find(b,n_r,n_c,idx+1,word,vis,m,n)){
                    return true;
                }
            }
        }
        vis[r,c]=false;
        return false;
    }
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;
        var vis = new bool[m,n];
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                if(board[i][j] == word[0]){
                    bool ans = find(board,i,j,1,word,vis,m,n);
                    if(ans) return true;
                }
            }
        }
        return false;
    }
}