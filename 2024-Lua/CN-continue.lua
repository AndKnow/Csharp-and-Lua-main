::s1:: --定义一个标签
do
    print("qqq")
end

for i=1,3 do
    if i == 2 then
        goto s1 --当i等于2时跳转到标签s1
    end
    print(i)
end