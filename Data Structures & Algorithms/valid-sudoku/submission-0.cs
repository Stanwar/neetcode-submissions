public class Solution {
    
    public bool IsValidSudoku(char[][] board) {
        // 9 row sets, 9 col sets, 9 square sets
        HashSet<int>[] rows = new HashSet<int>[9];
        HashSet<int>[] cols = new HashSet<int>[9];
        HashSet<int>[] squares = new HashSet<int>[9];

        // Initialize
        for (var i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<int>();
            cols[i] = new HashSet<int>();
            squares[i] = new HashSet<int>();
        }

        if (board.Length != 9){
            return false;
        }

        // Validations
        // 1. Check row
        // 2. Check col
        // 3. Check square
        for (var i=0; i < 9; i++){
            for (var j=0; j< 9; j++){
                var boardCharacter = board[i][j];

                if (boardCharacter == '.'){
                    // Dont check
                    continue;
                }

                // Determine square index
                int squareIndex = (i / 3) * 3 + (j / 3);

                //Convert to integer
                var boardPositionValue = boardCharacter - '0';

                if (rows[i].Contains(boardPositionValue)){
                    return false;
                }

                if (cols[j].Contains(boardPositionValue)){
                    return false;
                }

                if (squares[squareIndex].Contains(boardPositionValue)){
                    return false;
                }

                rows[i].Add(boardPositionValue);
                cols[j].Add(boardPositionValue);
                squares[squareIndex].Add(boardPositionValue);
            }
        }

        // No validation failed
        return true;
    }
}
