local function ipairs_print_keyvalue(...)
    for index, value in ipairs(...) do
        print(index ..":".. value)
    end
end

local function pairs_print_keyvalue(...)
    for index, value in pairs(...) do
        print(index ..":".. value)
    end
end

-- 自定义索引和访问
local table1 = {[6] = "1", ["0"] = "2", 2, 4, 6, [5] = "7"}
print(#table1)
ipairs_print_keyvalue(table1)
pairs_print_keyvalue(table1)

-- 数组和遍历
-- 遍历nil
local table2 = {1,2,3,nil,"hello", world}
print(#table2)
ipairs_print_keyvalue(table2)
pairs_print_keyvalue(table2)


-- 二维数组和遍历
print("two Dimension array nil")
local ary2 = {{1,2,111}, {"hello", "lua"}}

local t = {1, nil, 3, nil, 5}

for key1, value1 in pairs(ary2) do
    for key2, value2 in pairs(value1) do
        print(key1, key2, value2)
    end
end

-- 字典
    -- 定义
local dic1 = {["key1"] = "value1", ["key2"] = "value2"}

    -- 两种访问
print(dic1["key1"])
print(dic1.key2)

    -- 修改或者新增
    -- 删除
dic1["key1"] = "value changed"
dic1.key2 = nil
dic1.key3 = "new value"

print(dic1["key1"])
print(dic1.key2)
print(dic1["key3"])

-- (静态)类
    -- 类定义变量以及函数
local people = {
    age = 18,
    name = "DragonBorn",
    speak = function (x)
        print(string.format("I'm %s, and my age is %d", x.name, x.age))
    end
}

print(people.age);
print(people["name"])
people.speak(people)

    -- 补充定义变量或者函数
people.sex = "man"
people["salary"] = 18000
people.month = 6

-- 冒号定义和self,冒号访问以及传入参数
function  people:speak2()
    print(string.format("I'm %s, and my age is %d, %s, %d, %d", self.name, self.age, self.sex, self.salary, self.month))
end

function  people:speak3(ad_param)
    print(string.format("I'm %s, and my age is %d, %s, %d, %d", self.name, self.age, self.sex, self.salary, self.month))
    print("additional param", ad_param)
end

-- people.speak2(people)
-- people:speak2()
-- people:speak2();
people:speak3("heiheihei")

-- 表公共操作
local table3 = {1, 22, 311 , 10, 20}
pairs_print_keyvalue(table3)

    -- 插入
table.insert(table3, 3, 777)
print(#table3)
pairs_print_keyvalue(table3)

    -- 删除
table.remove(table3, 1)
print(#table3)
pairs_print_keyvalue(table3)

    -- 排序
table.sort(table3)
pairs_print_keyvalue(table3)

table.sort(table3, function (x,y)
    return x > y
end)
pairs_print_keyvalue(table3)

    -- 拼接
local table4 = {"aaa", "bbb", "ccc", "ddd"}
print(table.concat(table4, "|"))
print(table.concat(table4, "|", 2, 3))
