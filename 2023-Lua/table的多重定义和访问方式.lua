local tab1 = {"China", "American", "English"}
-- 表的常规定义,只初始化内容,那么key就是1,2,3
for k,v in pairs(tab1) do
    print(k .. " : " .. v)
end

-- 表的key初始化,通过table.key进行访问
local tab2 = {key1 = "hello ", key2 = "world ", key3 = "hi~ "}

print(tab2.key1);


-- 在使用数字索引的
local tab3 = {}
local key = 10
tab3[key] = "tab3[key]"
tab3["key"] = "tab3['key']"

for k, v in pairs(tab3) do
    print(k .. " : " .. v)
end
