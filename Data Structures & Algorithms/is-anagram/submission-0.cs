public class Solution {
    public bool IsAnagram(string s,string t) {
        if(s.Length != t.Length){
            return false;
        }
        else{

        
        Dictionary<char , int > harf_sayilari = new                     Dictionary<char,int>();
        foreach (char harf in s){
            if (harf_sayilari.ContainsKey(harf)){
                harf_sayilari[harf]++;
            }
            else{
                harf_sayilari[harf] = 1;
            }
            
        }
        foreach (char harf in t)
        {
        if(!harf_sayilari.ContainsKey(harf) || harf_sayilari[harf] == 0){
            return false;
            
        }
        else{
            harf_sayilari[harf] --;
        }
        }
        return true;
        


        }

    }
}
