-- 无参数无返回值
function f1()
    print("f1");
end

f1()
-- 有参数
local v2 = {["key1"] = "hello", ["key2"] = "world"}

function f2(x)
    print(x.key1)
    print(x.key2)
end

f2(v2)

-- 有返回值
function f3()
    return "I'm f3"
end

local v3 = f3()
print(v3)

-- 函数重载

-- 变长参数
local v4 = {"123", 234, "hahah", nil, "project s"}

function f4(...)
    print(#...)
    for k,v in pairs(...) do
        print(k .. ":" .. v)
    end

    for k,v in ipairs(...) do
        print(k .. ":" .. v)
    end
end

f4(v4)
f4({1,2,3,4})

-- 函数嵌套
    -- 函数变量返回
function f5()
    return function (value2)
        print("inner f5 return func" .. value2)
        print(value2)
    end
end

local v5 = f5   --错误的
local v5 = f5() -- 正确的

print(type(v5))
v5("hahah v5-> f5")

    -- 闭包
function f6(value1)
    return function (value2)
        print(value1 .."~~".. value2)
    end
end

local v61 = f6("hello")

v61("world")