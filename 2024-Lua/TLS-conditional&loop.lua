-- 条件分支语句
    -- if elseif else
math.randomseed(os.time())
local random_number = math.random(1, 100)
random_number = math.random(1, 100)
print(random_number)

if random_number < 30 then
    print("less than 30")
elseif random_number < 60 then
    print("less than 60")
else
    print("more than 60")
end

-- 循环语句
    -- for
for i = 1, 10, 2 do
    print("for", i)
end

    -- while
local loop_value = 10
while loop_value < 200 do
    loop_value = loop_value + 30
    print(loop_value)
end

    -- repeat
local repeat_value = 30
repeat
    repeat_value = repeat_value + 30
    print(repeat_value)
until repeat_value > 200