public class Solution {
    public int KthGrammar(int N, int K) {
        if (K == 1 || N == 1){
            return 0;
        }
        if (K%2 == 0){
            //right node
            return KthGrammar(N-1,K/2) == 0 ? 1 :0;
        } else {
            //left node
            return KthGrammar(N-1, (K+1)/2) == 0 ? 0 :1;
        }
    }
}