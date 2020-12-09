class Solution {
    public int reversePairs(int[] nums) {
        // 离散化
        Set<Integer> set = new TreeSet<Integer>();
        for(int num : nums)
            set.add(num);
        
        Map<Integer, Integer> map = new HashMap<>();
        int idx = 1;
        for(int num : set)
            map.put(num, idx++);

        int res = 0;
        BIT bit = new BIT(map.size());
        for(int i = 0; i < nums.length; i++){
            int left = map.get(nums[i]);
            res += i - bit.getSum(left);
            bit.update(left, 1);
        }

        return res;
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