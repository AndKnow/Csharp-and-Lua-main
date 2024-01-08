local raw_table1 = setmetatable({key1 = "hello"}, {
    __index = {key2 = "world"}
})

print(raw_table1.key1, raw_table1.key2)

local raw_table2 = setmetatable({key1 = "nihao"}, {
    __index = function (self, key)
        print("__index",self, key)
        return "DragonBorn"
    end
})

print(raw_table2.key1, raw_table2.key2, raw_table2.key3)