-- 运算符
    -- 算术运算符
print("123" + 20)
print("123" - 20)
print("123" .. 20)
        -- 幂运算
print(2^5)

    -- 条件运算符
        -- 不等于
local val1 = "qqq"
if val1 ~= "qqq" then
    print("no equal")
else
    print("yes")
end

    -- 逻辑运算符
        -- 与 或 非
print(1 and 2)
print(nil and 2)
print(1 or 2)
print(nil or 2)
print(not 1)
v1 = not nil;
print(type(v1))
print(v1)

    -- 位运算符
        -- 不支持

    -- 三目运算符
        -- 特殊的三目运算符
x = 100
y = 20
z = (x > y) and x or y
print(z)