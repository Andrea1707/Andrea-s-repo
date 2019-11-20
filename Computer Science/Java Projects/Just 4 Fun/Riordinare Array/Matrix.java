import java.util.Random;

/**
 * matrix
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

    public static String MatrixInfo(int [][] matrix){
        String  result;
        int sum=0, count_rows=0, count_column=0;
        
        for (int i=0 ; i < matrix.length ; i++ ) {
            count_rows++;
            for (int k=0; k < matrix[i].length; k++ ) {
                count_column++;
               sum += matrix [i] [k];
            }
        }
        result="Sum of the values inside the matrix: " + Integer.toString(sum) + "\n";
        if( count_column == count_rows) {
            int [] values = new int[matrix.length];
            int j=0;
            result+="The matrix's squared. \n";
            for (int i=0 ; i < matrix.length ; i++ ) {
                for (int k=0; k < matrix[i].length; k++ ) {
                    if(i==k){
                        values[j]=matrix[i][k];
                        j++;
                    }
                   
                }
            }
        result+="The diagonal is: [ ";
            for( int i = 0 ; i < values.length ; i++){
                if(i!=values.length-1)
                result+= Integer.toString(values[i]) + ",";
                else
                result+=Integer.toString(values[i])+ "]\n";
            }


        }else{
            result+= "The matrix isn't squared";
        }

        



        return result;
    }

}