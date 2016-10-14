public class Solution {
    public int LadderLength(string beginWord, string endWord, ISet<string> wordList) {
        if (beginWord == endWord) {
            return 1;
        }
        
        if (wordList.Count == 0) {
            return 2;
        }
        
        var queue = new Queue<string>();
        queue.Enqueue(beginWord);
        var count = 1;
        var queueSize = queue.Count;
        while (queueSize > 0) {
            count += 1;
            for (int i = 0; i < queueSize; i++) {
                var cur = queue.Dequeue();
                var next = GetOneLetterDiffList(cur, wordList);
                foreach(var w in next) {
                    if (w == endWord) {
                        return count;
                    }else{
                        queue.Enqueue(w);
                        wordList.Remove(w);
                    }
                }
            }

            queueSize = queue.Count;
        }
        
        return 0;
    }
    
    private List<string> GetOneLetterDiffList(string source, ISet<string> wordList) {
        var list = new List<string>();
        var len = source.Length;
        for (int i = 0; i < len; i++) {
            StringBuilder sb = new StringBuilder(source);
            for (char ch = 'a'; ch <= 'z'; ch++) {
                sb[i] = ch;
                var theString = sb.ToString();
                if (wordList.Contains(theString) && theString != source) {
                    list.Add(theString);
                }
            }
        }
        
        return list;
    }
}