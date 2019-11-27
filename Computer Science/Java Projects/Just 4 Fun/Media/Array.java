import java.util.Random;

/**
 * Array
 */
public class Array {

    public static int[] GeneraArray(int index, int bound){
        int [] array = new  int[index];
        Random rand = new Random();
        for (int i=0; i<array.length;i++){
            array[i]= rand.nextInt(bound);
        }

        return array;
    }
    public static void StampaArray(int[] a){
        for(int i=0; i<array.length;i++){
            System.out.println ( a [i]);
        }
    }

}