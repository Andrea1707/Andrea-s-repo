import java.util.Random;

/**
 * Matrix
 */
public class Matrix {
    public static int[][] RandomMatrix(int row, int column, int bound){
        int [][] matrix = new int [row] [column];
        Random random = new Random();
        int low = bound * -1;

        for ( int i=0 ; i < matrix.length ; i++ ) {
            for ( int k=0; k <  matrix[i].length; k++ ) {
                int result = random.nextInt( bound - low ) + low;
                matrix[i][k]=result;
            }
        }

        return matrix;
        
        
    
    }

    public static String ToString( int[] [] matrix ){
        String result;

        result="== Generated Matrix:\n";
        for ( int i=0 ; i < matrix.length ; i++ ) {
            for ( int k=0; k < matrix[i].length; k++ ) {
                if ( k == ( matrix[i].length - 1 ) )
                result += Integer.toString ( matrix [i] [k] ) + "\n";
                else
                result += Integer.toString ( matrix[i] [k] ) + ", ";
            }
            result +="\n";
        }
        return result;
    }

    
}