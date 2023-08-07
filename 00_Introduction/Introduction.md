## Complexity
### Time Complexity
O(1) < O(logn) < O(n) < O(n logn) < O(n^2) < O(2^n) < O(n!) <br /> <br />
**O(1)** - 与输入数据 n 无关
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
**O(logn)** - 每轮缩减, 常见于二分查找和分治算法
```csharp
/* 每轮操作次数缩减一般, 即以2为底*/
int logarithmic(float n) {
    int count = 0;
    while (n > 1) {
        n = n / 2;
        count++;
    }
    return count;
}
```
**O(n)** - 与输入数据 n 成线性关系, 常出现在单层循环中
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
**O(n logn)** - 常出现于嵌套循环中, 一层是O(logn), 一层是O(n); 常见于 快速排序、归并排序、堆排序等
```csharp
int linearLogRecur(float n) {
    if (n <= 1) return 1;
    int count = linearLogRecur(n / 2) +
                linearLogRecur(n / 2);
    for (int i = 0; i < n; i++) {
        count++;
    }
    return count;
}
```
**O(n^2)** - 常出现在嵌套循环中，外层循环和内层循环都为 O(n)
```csharp
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
**O(2^n)** - 若一个问题使用「暴力枚举」求解的时间复杂度为 O(2^n), 那么通常需要使用「动态规划」或「贪心算法」等方法来解决; 常出现于递归函数 
```csharp
int exponential(int n) {
    int count = 0, bas = 1;
    // cell 每轮一分为二，形成数列 1, 2, 4, 8, ..., 2^(n-1)
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < bas; j++) {
            count++;
        }
        bas *= 2;
    }
    // count = 1 + 2 + 4 + 8 + .. + 2^(n-1) = 2^n - 1
    return count;
}
```
**O(n!)** - 阶乘通常使用递归实现。
```csharp
/* 阶乘阶（递归实现） */
int factorialRecur(int n) {
    if (n == 0) return 1;
    int count = 0;
    // 从 1 个分裂出 n 个
    for (int i = 0; i < n; i++) {
        count += factorialRecur(n - 1);
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
