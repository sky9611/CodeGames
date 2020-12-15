public class QuickSort{
    public static void main(String[] args){
        int[] arr = new int[]{2,96,3,156,489,1256,456,48,4789,456,531,3,156,487,9,3,6,9};
        sort(arr);
        for(int i : arr)
            System.out.print(i + " ");
    }

    public static void sort(int[] arr){
        sort(arr, 0, arr.length-1);
    }

    public static void sort(int[] arr, int low, int high){
        if(low < high){
            int pi = partition(arr, low, high);
            sort(arr, low, pi-1);
            sort(arr, pi, high);
        }
    }

    public static int partition(int[] arr, int low, int high){
        int pivot = arr[high];
        int i = low - 1;
        for(int j = low; j <= high; j++){
            if(arr[j] <= pivot){
                i++;
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
        }
        return i;
    }
}
