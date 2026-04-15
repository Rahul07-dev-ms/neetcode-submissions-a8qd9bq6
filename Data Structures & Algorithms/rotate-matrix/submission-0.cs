public class Solution {
    private void Swap(int[][] arr, int i, int j){
        int temp = arr[i][j];
        arr[i][j] = arr[j][i];
        arr[j][i] = temp;
    }
    public void Rotate(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        //transpose
        for(int i=0; i<m; i++){
            for(int j=0; j<=i; j++){
                Swap(matrix,i,j);
            }
        }
        //reverse
        int row = 0;
        while(row < m){
            int i=0;
            int j=n-1;
            while(i < j){
                int temp = matrix[row][i];
                matrix[row][i] = matrix[row][j];
                matrix[row][j]=temp;
                i++;
                j--;
            }
            row++;
        }
    }
}