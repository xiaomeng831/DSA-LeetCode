## Complexity
### Time Complexity
**O(1)**
```csharp
/* 不论 n 是几, 该函数操作次数永远是 100000次 */
int constant(int n) {
    int count = 0;
    int size = 100000;
    for (int i = 0; i < size; i++)
        count++;
    return count;
}
```
**O(n)**
```csharp
/* 函数操作次数是由数组 nums 的长度决定,即为 n 次 */
int arrayTraversal(int[] nums) {
    int count = 0;
    foreach (int num in nums) {
        count++;
    }
    return count;
} 
```
**O(n^2)**
```csharp
/* 平方阶 */
int quadratic(int n) {
    int count = 0;
    // 循环次数与数组长度成平方关系
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            count++;
        }
    }
    return count;
}
```
### 2.空间复杂度
## 2.Data Structure
### 1.逻辑结构
- 线性数据结构(一对一, 顺序): 数组、链表、栈、队列
- 非线性数据结构: 树、堆、图
    - 树形结构(一对多): 树、堆、哈希表(字典)
    - 网状结构(多对多): 图
- 哈希表: 有说是线性的, 也有说是非线性的
### 2.物理结构
- 连续 数组
- 离散 链表
- 其他数据结构都是基于数组, 链表 或二者的组合实现的
## 3.基本数据类型
## 4.数字编码
## 5.字符编码
