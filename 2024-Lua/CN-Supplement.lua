-- 变长参数和select
function f1(...)
    local ary = {...}
    for key, value in ipairs(ary) do
        print(key, value)
    end

    print(select("#",  ...))
    print(select(3,  ...))
end

local table1 = {1,2,3,4,5}
print("select table ",select("#", table1))
f1(table1, "qqq", nil, 11,22,33)

-- 除法和整除
print(20/3)
print(20 // 3)