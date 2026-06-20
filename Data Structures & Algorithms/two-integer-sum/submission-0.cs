public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        return BrutForce(nums, target);
    }

    public int[] BrutForce(int[] nums, int target){
        for(int i = 0; i< nums.Length - 1; i++){
            for(int j = (i + 1); j < nums.Length; j ++){
                int suma = nums[i] + nums[j];
                if(suma == target){
                    return[i, j];
                }
            }
        }
        return[-1, -1];
    }
}
