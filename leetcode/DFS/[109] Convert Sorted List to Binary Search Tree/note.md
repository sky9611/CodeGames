- naive approach:
  - 空间换时间，转换成list/数组，然后递归求解（Q108）
- 相同速度，更少空间
  - 模拟inorder遍历：
    - 左递归 -> 创当前节点 -> 赋值左节点 -> 右递归