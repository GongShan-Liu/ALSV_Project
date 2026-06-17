# 设置操纵角色的输入
- 一般有两种方案
  - 旧的方案是项目设置的Input （5.1之后已弃用）
  - 新的方案是使用增强输入系统 (Enhanded Input System)
    1. 先创建Input Action
    2. 再创建Input Mapping Context映射对象, 并把Input Action内容设置到映射中
    3. 最后在Character蓝图或者Controller蓝图使用Add Mapping Context加载映射对象
