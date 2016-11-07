public class Solution {
    public int CountBattleships(char[,] board) {
        var height = board.GetLength(0);
        var width = board.GetLength(1);
        var count = 0;
        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width; j++) {
                if (board[i, j] == '.') {
                    continue;
                }
                if (j > 0 && board[i,j-1] == 'X') {
                    continue;
                }
                if (i > 0 && board[i-1,j] == 'X') {
                    continue;
                }
                count += 1;
            }
        }
        return count;
    }
}