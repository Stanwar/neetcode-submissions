public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result= new int[nums.Length];
        var product = 1;
        var nonZeroProduct = 1;
        var zero = false;
        var allZeroes = true;
        // Division
        // Calculate non zero product
        for (var i =0; i< nums.Length; i++){
            // Did we already encounter a zero?
            if (zero && nums[i] == 0){
                nonZeroProduct = 0;
                continue;
            }

            if (nums[i] == 0){
                // Zero detected
                zero = true;
            }
            else {
                allZeroes = false;
                nonZeroProduct = nonZeroProduct * nums[i];
            }
        }
        
        for (var i=0; i<nums.Length; i++){
            if (allZeroes){
                result[i] = 0;
                continue;
            }
            if (nums[i] == 0 ){
                result[i] = nonZeroProduct;
                continue;
            }
            
            if (zero){
                result[i] = 0;
            }
            else {
                result[i] = nonZeroProduct/nums[i];
            }
        }
        return result;
    }
}
