local table1 = {1,5,76,21,324,5,}
local table2 = {}

table.sort({})

print(table2)

local t1 = table.concat(table2, "x")

print(type(t1))

for index, value in ipairs(table2) do
    print(value)
end