- 两种index：
  - `left = preorder[preindex+1]` 或者 `left = inorder[inindex-1]`, 两种情况边界条件和right的index表达式都不同，需要建立的map也不一样
- map的作用：
  - 加速（O(1)）
  - 查找一个值在另一个遍历中的位置（对应上一条，即只需一个map） 