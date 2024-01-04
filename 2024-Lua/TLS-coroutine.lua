-- 协程，thread
    -- 创建两种
local function fun1()
    for i = 1, 100, 1 do
        -- 挂起
        if i > 50 and i % 10 == 0 then
            print(coroutine.running())
            coroutine.yield()
        end

        print(i)
    end
end

local function fun2()
    for i = 200, 300, 1 do
        if i > 250 and i % 10 == 0 then
            coroutine.yield()
        end

        print(i)
    end
end

local t1 = coroutine.create(fun1)
local c1 = coroutine.wrap(fun2)

    -- 运行两种
coroutine.resume(t1)
c1()

    -- 挂起
coroutine.resume(t1)
c1()


    -- 状态
print(coroutine.status(t1))
coroutine.resume(t1)
coroutine.resume(t1)
coroutine.resume(t1)
coroutine.resume(t1)
print(t1)
print(coroutine.running())
print(coroutine.status(t1))