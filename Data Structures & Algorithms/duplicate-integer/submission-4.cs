public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();


        foreach(int target in nums){
            if(seen.Contains(target)){
                return true;
            }
            seen.Add(target);
        }
        return false;



    }
}