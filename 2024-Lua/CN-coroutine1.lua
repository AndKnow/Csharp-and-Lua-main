local function  f1()
    print("f1 1111")
    coroutine.yield()
    print("f1 22222")
end

local function f2()
    for i = 1, 10, 1 do
        print("f2", i)
        if i % 5 == 0 then
            coroutine.yield("qqqqqqq for yield")
        end
    end

    print("end f2")
end

-- create创建的协程是一次性道具,函数走完之后就没用了
local c1 = coroutine.create(f1)
local c2 = coroutine.create(f2)

print(coroutine.resume(c1))
print(coroutine.resume(c1))
print(coroutine.resume(c1))
print(coroutine.resume(c1))

print(coroutine.resume(c2))
print(coroutine.resume(c2))
print(coroutine.resume(c2))
print(coroutine.resume(c2))

-- wrap创建的更离谱,如果是结束的协程直接就报错了
local cf1 = coroutine.wrap(f1)
cf1()
cf1()
print(cf1())