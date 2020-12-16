package priv.wth;

public class Main {

    static final char[] charDict = new char[]{'0','1','2','3','4','5','6','7','8','9','A', 'B', 'C', 'D', 'E', 'F'};

    public static void main(String[] args){
        String number = "-465AB";
        int m = 13;
        int n = 2;
        System.out.println(toDigits(fromDigits(number, m), n));
    }

    // Convert a number N to its decimal representation in base b
    public static String toDigits(int N, int b){
        int originN = N;
        StringBuffer sb = new StringBuffer();
        N = Math.abs(N);
        while(N > 0){
            sb.append(charDict[N % b]);
            N /= b;
        }
        if(originN < 0) sb.append("-");
        return sb.reverse().toString();
    }

    // Compute the number N in base b to decimal
    public static int fromDigits(String N, int b){
        int res = 0;

        int i = N.charAt(0) == '-' ? 1 : 0;
        for(;i < N.length(); i++){
            char digit = N.charAt(i);
            res = res * b + (digit < 'A' ? (digit - '0') : (10 + digit - 'A'));
        }

        return N.charAt(0) == '-' ? (-res) : res;
    }
}
