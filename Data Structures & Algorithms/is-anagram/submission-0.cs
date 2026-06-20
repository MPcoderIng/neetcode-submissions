public class Solution {
    public bool IsAnagram(string s, string t) {
        return SortingMethod(s,t);
        //return HashesMethod(s,t);        
    }

    private bool HashesMethod(string s, string t){
            if(s.Count() != t.Count()){
                return false;
            }

            Dictionary<int, char> s1 = new Dictionary<int, char>();
            Dictionary<int, char> s2 = new Dictionary<int, char>();

            // s1.Add(0, s.ToCharArray());
            // s2.Add(1, t.ToCharArray());
            return false;

            // if(s1 == s2){
            //     return true;
            // }else {
            //     return false;
            // }
    }

    private bool SortingMethod(string s, string t){
                    if(s.Count() != t.Count()){
                return false;
            }
            
            char[] chars1 = s.ToCharArray();
            char[] chars2 = t.ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            string sortedS = new string(chars1);
            string sortedT = new string(chars2);

            Console.WriteLine(sortedS);
            Console.WriteLine(sortedT);

            if(sortedS.Equals(sortedT)){
                return true;
            }else{
                return false;
            }
    }
}
