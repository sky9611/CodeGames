public class QuickSort{
    public static void main(String[] args){
        // System.out.println("Hello World");

        
        int[] arr = new int[]{5,63,2,1,9,63,10,2,3,6,9};
        sort(arr);
        for(int i : arr)
            System.out.print(i + " ");
    }

    private static void sort(int[] arr){
        sort(arr, 0, arr.length-1);
    }

    private static void sort(int[] arr, int low, int high){
        if(low < high){
            int pi = partition(arr, low, high);
            sort(arr, low, pi-1);
            sort(arr, pi, high);
        }
    }

    private static int partition(int[] arr, int low, int high){
        int pivot = arr[high];
        int i = low - 1;
        for(int j = low; j < high; j++){
            if(arr[j] <= pivot){
                i++;
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
        }
        int tmp = arr[i+1];
        arr[i+1] = arr[high];
        arr[high] = tmp;
        return i+1;
    }
}
