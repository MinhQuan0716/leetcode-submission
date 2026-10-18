public class Solution {
    public int FindLHS(int[] nums) {
        int result = 0;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            } else{
                dict[nums[i]] = 1;
            }
        }
        foreach(KeyValuePair<int, int> entry in dict){
            int num = entry.Key;
            if(dict.ContainsKey(num + 1)){
                int countVal = dict[num] + dict[num + 1];
                result = Math.Max(result,countVal);
            }
        }
        return result;
    }
}