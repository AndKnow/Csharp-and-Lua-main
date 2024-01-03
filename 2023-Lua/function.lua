-- 函数的定义,参数连类型都能省略了
local function func(tab, x)
    for k,v in pairs(tab) do
        print(k .. " : " .. v)
    end
    print(x);
end

local tab1 = {1,2,3,4,5,6,"hello","world"}
func(tab1, "hi hi hi~")

-- 交换遍历
A = 999
B = 888
A,B = B,A
print(A .. B)