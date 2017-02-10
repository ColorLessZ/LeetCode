public class Solution {
    public string[] FindWords(string[] words) {
        var hashRow1 = new HashSet<char>(){'q','w','e','r','t','y','u','i','o','p'};
        var hashRow2 = new HashSet<char>(){'a','s','d','f','g','h','j','k','l'};
        var hashRow3 = new HashSet<char>(){'z','x','c','v','b','n','m'};
        var list = new List<string>();
        foreach(var word in words) {
            var len = word.Length;
            var count1 = 0;
            var count2 = 0;
            var count3 = 0;
            foreach(var c in word.ToLower()) {
                if (hashRow1.Contains(c)) {
                    count1 += 1;
                }
                if (hashRow2.Contains(c)) {
                    count2 += 1;
                }
                if (hashRow3.Contains(c)) {
                    count3 += 1;
                }
            }
            
            if (count1 == len || count2 == len || count3 ==len){
                list.Add(word);
            }
        }
        
        return list.ToArray();
    }
}