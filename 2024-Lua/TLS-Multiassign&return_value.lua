-- 多变量赋值
local a,b,c,d = 132, "hello world", false
print(a)
print(b)
print(c)
print(d)

-- 多返回值
local function f1()
    return 527, "hi vv"
end

print("```````````2")
a,c,b = f1()
print(a)
print(b)
print(c)

print("```````````3")
d = f1()
print(d)
print(_G["_"])