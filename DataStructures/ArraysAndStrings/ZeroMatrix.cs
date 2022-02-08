using System;

namespace ArraysAndStrings {
    public static class ZeroMatrix {
        
        public static void SetZeroColsAndRowsInMatrix(int[,] matrix) {

            var isFirstRowZero = false;
            var isFirstColumnZero = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if(matrix[i,0] == 0) isFirstColumnZero = true;
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if(matrix[0,i] == 0) isFirstRowZero = true;
            }
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == 0) {
                        matrix[0,j] = 0;
                        matrix[i,0] = 0;
                    }
                }
            }


            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if(matrix[i,0] == 0) {
                    NullifyRow(i, matrix);
                }
            }

            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                if(matrix[0,i] == 0) {
                    NullifyCol(i, matrix);
                }
            }

            if(isFirstColumnZero) NullifyCol(0, matrix);
            if(isFirstRowZero) NullifyRow(0, matrix);
        }

        private static void NullifyRow(int row, int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[row, i] = 0;
            }
        }

        private static void NullifyCol(int col, int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, col] = 0;
            }
        }
    }
}