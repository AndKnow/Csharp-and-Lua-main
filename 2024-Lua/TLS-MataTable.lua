-- 元表概念
local table1 = {key1 = "value1", key2 = "value2"}
local meta_table = {}

-- 元表设置
setmetatable(table1, meta_table);
    -- 设置
        -- __tostring,返回的是一个函数的返回值
meta_table.__tostring = function (x)
    print(x.key1)
    print("call __tostring")
    return "this is meta string"
end

print(tostring(table1))

        -- __call
meta_table.__call = function (x, y)
    print(x.key1)
    print(x.key2)
    print("param2:", y)
    print("call __call")
    return "this is meta call"
end

print(table1("insert param2"))

        -- 运算符重载
local table2 = {key1 = "hello"}
meta_table.__add = function (x, y)
    return x.key1 .. y.key1
end

print(table1 + table2)
print(table2 + table1)

-- __index _newIndex
local table3 = {key1 = "table3 value1", key3 = "table3 value3"}
meta_table.__index = table3
print(table1.key1)
print(table1.key3)

-- 原表获取
print(rawget(table1, "key1"))
print(rawget(table1, "key3"))

-- 原始值获取