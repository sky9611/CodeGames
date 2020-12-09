import java.util.*;

public class ChineseToDigits {
    private static Map<String, Integer> numMap = new HashMap<>();


    private static Map<String, Integer> unitMap = new HashMap<>();

    public static void main(String[] args){
        // System.out.println("Hello World");

        numMap.put("一", 1);
        numMap.put("二", 2);
        numMap.put("三", 3);
        numMap.put("四", 4);
        numMap.put("五", 5);
        numMap.put("六", 6);
        numMap.put("七", 7);
        numMap.put("八", 8);
        numMap.put("九", 9);

        unitMap.put("十", 10);
        unitMap.put("百", 100);
        unitMap.put("千", 1000);
        
        String zhNumStr = "一亿零三百二十三";

        // 根据“亿”和“万”将中文数字分成三段
        int indexHundredMillion = zhNumStr.indexOf("亿");
        if(indexHundredMillion == -1) indexHundredMillion = 0;
        int indexTenMillion = zhNumStr.indexOf("万");
        if(indexTenMillion == -1) indexTenMillion = indexHundredMillion;

        String partOne = zhNumStr.substring(0, indexHundredMillion);
        String partTwo = zhNumStr.substring(indexHundredMillion, indexTenMillion);
        String partThree = zhNumStr.substring(indexTenMillion, zhNumStr.length());

        // 将结果相加
        int res = zhNumToArabicNum(partOne)*100000000 + zhNumToArabicNum(partTwo)*10000 + zhNumToArabicNum(partThree);        
        System.out.println(res);
    }

    /** 
    * @descroption: 将一万以下的中文数字转成阿拉伯数字
    */
    private static int zhNumToArabicNum(String zhNumStr){
        if(zhNumStr.length() == 0) return 0;
        String[] zhNumArr = zhNumStr.split("");
        Stack<Integer> stack = new Stack<>();
        for(String str : zhNumArr){
            int num = numMap.getOrDefault(str, -1);
            int unit = unitMap.getOrDefault(str, -1);
            if(num != -1){
                stack.push(num);
            } else if(unit != -1){
                if(stack.isEmpty())
                    stack.push(unit);
                else
                    stack.push(stack.pop() * unit);
            }
        }

        return stack.stream().mapToInt(s -> s).sum();
    }
}
