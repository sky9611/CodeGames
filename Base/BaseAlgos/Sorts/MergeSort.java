public class MergeSort {
    public static void main(String[] args){
        int[] arr = new int[]{5,63,2,1,9,63,10,2,3,6,9};
        sort(arr);
        for(int i : arr)
            System.out.print(i + " ");
    }

    public static void sort(int[] arr){
        if(arr == null || arr.length == 0) return;
        int[] tmp = new int[arr.length];
        sort(arr, 0, arr.length-1, tmp);
    }

    public static void sort(int[] arr, int first, int last, int[] tmp){
        if(first < last){
            int mid = first + (last - first) / 2;
            // 递归归并左边元素
            sort(arr, first, mid, tmp);
            // 递归归并右边边元素
            sort(arr, mid+1, last, tmp);
            merge(arr, first, mid, last, tmp);
        }
    }

    /**
     * 合并两个有序数列
     * arr[first...mid]为第一组
     * arr[mid+1...last]为第二组
     * temp[]为存放两组比较结果的临时数组
     */
    public static void merge(int[] arr, int first, int mid, int last, int[] tmp){
        // i为第一组的起点, j为第二组的起点
        int i = first, j = mid + 1;
        // m为第一组的终点, n为第二组的终点
        int m = mid, n = last;
        // k用于指向temp数组当前放到哪个位置
        int k = 0;

        // 将两个有序序列循环比较, 填入数组temp
        while(i <= m && j <= n){
            if(arr[i] < arr[j])
                tmp[k++] = arr[i++];
            else
                tmp[k++] = arr[j++];
        }

        // 如果比较完毕, 第一组还有数剩下, 则全部填入temp
        while(i <= m)
            tmp[k++] = arr[i++];

        // 如果比较完毕, 第二组还有数剩下, 则全部填入temp
        while(j <= n)
            tmp[k++] = arr[j++];
        
        // 将排好序的数填回到array数组的对应位置
        for(i = first; i <= last; i++){
            arr[i] = tmp[i-first];
        }
    }
}
