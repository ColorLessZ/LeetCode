public class Solution {
    public bool IsValidSudoku(char[,] board) {
        var width = board.GetLength(0);
        var height = board.GetLength(1);
        if (width != 9 || height != 9) {
            return false;
        }
        
        for(int i = 0; i<width; i++) {
            var bond = new int[] { i, i, 0, 8 };
            if (!IsValidCell(board,bond)) {
                return false;
            }
        }
        
        for(int i = 0; i<height; i++) {
            var bond = new int[] { 0, 8, i, i };
            if (!IsValidCell(board,bond)) {
                return false;
            }
        }
        
        for (int i=0; i<3; i++) {
            for(int j=0; j<3; j++){
                var bond = new int[] { 3*i, 3*i+2, 3*j, 3*j+2 };
                if (!IsValidCell(board,bond)) {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    private bool IsValidCell(char[,] board, int[]bond) {
        var hashSet = new HashSet<char>();
        var row1 = bond[0];
        var row2 = bond[1];
        var col1 = bond[2];
        var col2 = bond[3];
        for(int col = col1; col <= col2; col++) {
            for(int row = row1; row <= row2; row++) {
                var val = board[col,row];
                if (val != '.') {
                    if (hashSet.Contains(val)) {
                        return false;
                    } else {
                        hashSet.Add(val);
                    }
                }
            }
        }
        
        return true;
    }
}