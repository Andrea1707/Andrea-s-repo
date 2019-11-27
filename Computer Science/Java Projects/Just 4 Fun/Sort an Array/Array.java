import java.util.Random;

/**
 * Array
 */
public class Array {

    public static int[] RandomArray(int index, int bound){
        int [] a = new int[index];
        Random rand = new Random();
        for(int i=0;i<a.length;i++){
            a[i]=rand.nextInt(bound);
        }
        return a;
    }

    public static int[] insertionSortCrescente(int[] arr){
        for (int i=1; i <arr.length; i++)
           for (int j=i; j>0 && arr[j]<arr[j-1]; j--)
              if(arr[j] < arr[j-1]){
                 int temp = arr[j];
                 arr[j] = arr[j-1];
                 arr[j-1] = temp;
              }
        return arr;
    }
    public static String PrintArray(int [] a){
        String res = "== Array == \n";
        
        for(int i = 0; i< a.length ; i++){
            if(i<(a.length-1))
                res+= Integer.toString(a[i]) + ", ";
            else
                res+= Integer.toString(a[i]) + "; \n";

        }
        return res;
    }
              
     
}