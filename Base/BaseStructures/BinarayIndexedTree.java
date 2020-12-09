public class BinarayIndexedTree {
    int[] c;
    int n;

    public BinarayIndexedTree(int n){
        this.n = n;
        c = new int[n+1];
    }

    private lowbit(int x){
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
