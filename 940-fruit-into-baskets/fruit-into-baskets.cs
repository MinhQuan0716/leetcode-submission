public class Solution {
    public int TotalFruit(int[] fruits) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int left = 0, result = 0;
        for(int i = 0; i<fruits.Length; i++){
            if(dict.ContainsKey(fruits[i])){
                 dict[fruits[i]]++;
            } else{
                   dict[fruits[i]] = 1;
            }
            while(dict.Count() > 2){
                dict[fruits[left]]--;
                if(dict[fruits[left]] == 0){
                    dict.Remove(fruits[left]);
                }
                left++;
            }
            result = Math.Max(result, i - left + 1);
        }
        return result;
    }
}