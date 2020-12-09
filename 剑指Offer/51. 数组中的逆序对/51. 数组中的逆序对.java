class Solution {
    public int reversePairs(int[] nums) {
        // // 树状数组
        // // 离散化
        // Set<Integer> set = new TreeSet<Integer>();
        // for(int num : nums)
        //     set.add(num);
        
        // Map<Integer, Integer> map = new HashMap<>();
        // int idx = 1;
        // for(int num : set)
        //     map.put(num, idx++);

        // int res = 0;
        // BIT bit = new BIT(map.size());
        // for(int i = 0; i < nums.length; i++){
        //     int left = map.get(nums[i]);
        //     res += i - bit.getSum(left);
        //     bit.update(left, 1);
        // }

        // return res;

        // 归并
        return reversePairs(nums, 0, nums.length-1, new int[nums.length]);
    }

    private int reversePairs(int[] nums, int start, int last, int[] tmp){
        if(start >= last) return 0;
        int mid = start + (last - start) / 2;
        int leftCount = reversePairs(nums, start, mid, tmp);
        int rightCount = reversePairs(nums, mid + 1, last, tmp);

        if(nums[mid] <= nums[mid + 1])
            return leftCount + rightCount;
        
        int crossCount = mergeCount(nums, start, mid, last, tmp);
        return leftCount + crossCount + rightCount;
    }

    private int mergeCount(int[] nums, int start, int mid, int last, int[] tmp){
        int i = start, j = mid + 1, k = 0, count = 0;
        while(i <= mid && j <= last){
            if(nums[i] <= nums[j])
                tmp[k++] = nums[i++];
            else{
                count += mid - i + 1;
                tmp[k++] = nums[j++];
            }
        }
        while(i <= mid)
            tmp[k++] = nums[i++];
        while(j <= last)
            tmp[k++] = nums[j++];

        for(i = start; i <= last; i++){
            nums[i] = tmp[i-start];
        }

        return count;
    }
}

class BIT {
    int[] c;
    int n;

    public BIT(int n){
        this.n = n;
        c = new int[n+1];
    }

    private int lowbit(int x){
        return x & (-x);
    }

    public void update(int x, int k){
        while(x <= n){
            c[x] += k;
            x += lowbit(x);
        }
    }

    public int getSum(int x){
        int res = 0;
        while(x > 0){
            res += c[x];
            x -= lowbit(x);
        }
        return res;
    } 
}