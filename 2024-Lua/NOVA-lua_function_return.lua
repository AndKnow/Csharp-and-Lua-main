function func(value)
    print(type(value), " ", value)
    return "hello"
end

function func2(value)
    print("dddd")
    return func(value)
end

local func3 = func2(111)
print(func3)