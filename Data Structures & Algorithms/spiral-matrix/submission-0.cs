public class Solution {
    private void spiralAns(int row_no,int m,int col_no,int n,List<int> ans,int[][] matrix){
        //step-1
        for(int i=col_no; i<=n; i++){
            ans.Add(matrix[row_no][i]);
        }
        //step-2
        for(int i=row_no+1; i<m; i++){
            ans.Add(matrix[i][n]);
        }
        //step-3
        if(row_no != m){
            for(int i=n; i>=col_no; i--){
                ans.Add(matrix[m][i]);
            }
        }
        //step-4
        if(col_no != n){
            for(int i=m-1; i>row_no;i--){
                ans.Add(matrix[i][col_no]);
            }
        }
    }
    public List<int> SpiralOrder(int[][] matrix) {
        int m = matrix.Length-1;
        int n = matrix[0].Length-1;
        int col_no = 0, row_no=0;
        var ans = new List<int>();
        while(row_no <= m && col_no <= n){
            spiralAns(row_no,m,col_no,n,ans,matrix);
            row_no++;
            col_no++;
            m--;
            n--;
        }
        return ans;
    }
}