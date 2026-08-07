public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> gorulenler = new HashSet<int>();
        foreach (int sayi in nums){
            if(gorulenler.Contains(sayi)){
                return true;
            }
            else{
                gorulenler.Add(sayi);
            }
        }
        return false;
    }
}