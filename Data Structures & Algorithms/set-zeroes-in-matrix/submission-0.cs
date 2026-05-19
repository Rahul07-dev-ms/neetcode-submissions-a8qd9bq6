public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool col = false;
        int m = matrix.Length;
        int n = matrix[0].Length;
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                if(matrix[i][j] == 0){
                    if(j==0){
                        col = true;
                        continue;
                    }
                    matrix[i][0]=0;
                    matrix[0][j]=0;
                }
            }
        }
        for(int c=1; c<n; c++){
            if(matrix[0][c] == 0){
                for(int r=0; r<m; r++){
                    matrix[r][c]=0;
                }
            }
        }
        for(int r=0; r<m; r++){
            if(matrix[r][0]==0){
                for(int c=0; c<n; c++){
                    matrix[r][c]=0;
                }
            }
        }
        if(col){
            for(int i=0; i<m; i++){
                matrix[i][0]=0;
            }
        }
    }
}