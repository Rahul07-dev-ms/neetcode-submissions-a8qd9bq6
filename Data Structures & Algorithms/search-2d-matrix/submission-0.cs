public class Solution {
    private int find(int[][] arr, int t){
        int low = 0;
        int high = arr.Length-1;
        int col = arr[0].Length;
        int mid=0;
        while(low<=high){
            mid = low + (high-low)/2;
            if(arr[mid][0] > t){
                high = mid-1;
            }
            else{
                low = mid+1;
                if(arr[mid][col-1] >= t){
                    return mid;
                }
            }
        }
        return -1;
    }
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        if(m==1 && n==1) return matrix[0][0] == target;
        int idx = find(matrix, target);
        if(idx == -1) return false;
        int low = 0;
        int high = matrix[0].Length-1;
        while(low <= high){
            int mid = low + (high-low)/2;
            if(matrix[idx][mid] == target){
                return true;
            }
            else if (matrix[idx][mid] > target){
                high = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        return false;
    }
}