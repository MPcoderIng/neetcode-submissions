public class Solution {
    public bool hasDuplicate(int[] nums) {       
int counter = 0; 
        for(int i = 0; i <= nums.Length - 1; i++){      
           counter = Counter(nums[i], nums);           
           if(counter > 1){
        return true;
       }      
        }       
       return false;
    }

    public int Counter(int buscado, int[] numbers){
        int contador = 0;
        foreach(int element in numbers){
            if(element == buscado){
                contador++;
            }
        }
        return contador;      
    }
}