/**
 * main
 */
public class Main {

    public static void main(String[] args) {
        int [] a = Array.RandomArray(10, 100);
        System.out.println(Array.PrintArray(a));

        System.out.println(Array.PrintArray(Array.insertionSortCrescente(a)));

    }
}