using System;

namespace ArraysAndStrings {
    public static class MatrixRotation {
        
        private class Coordinate {
            public int i { get; set; }
            public int j { get; set; }
        }
        public static void RotateMatrix(int[,] matrix) {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n/2; i++)
            {
                for (int j = i; j < (n-1) - i; j++)
                {
                    
                    var coords = GetRotatedCoords(new Coordinate { i = i, j = j }, n - 1);
                    
                    var temp = matrix[i,j];
                    Coordinate currCord = new Coordinate { i = i, j = j};

                    for (int k = 0; k < coords.Length; k++)
                    {   
                        var coord = coords[k];
                        matrix[currCord.i,currCord.j] = matrix[coord.i,coord.j];
                        currCord.i = coord.i;
                        currCord.j = coord.j;
                    }

                    matrix[currCord.i,currCord.j] = temp;
                }
                Console.WriteLine();
            }
        }

        private static Coordinate[] GetRotatedCoords(Coordinate initialCoord, int size) {
            Coordinate[] coords = new Coordinate[3];

            coords[0] = new Coordinate { i = initialCoord.j, j = size - initialCoord.i };          
            coords[1] = new Coordinate { i = size - initialCoord.i, j = size - initialCoord.j };
            coords[2] = new Coordinate { i = size - initialCoord.j, j = initialCoord.i };

            return coords;
        }
    }
}