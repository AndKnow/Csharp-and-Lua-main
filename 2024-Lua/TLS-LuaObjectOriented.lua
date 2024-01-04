-- 封装
    -- new
Object = {
    key1 = "qqq",
    __tostring = function (x)
        return 
    end
}
function Object:new()
    local instance = {}
    setmetatable(instance, self)
    self.__index = self
    return instance
end

local i1 = Object:new()
i1.key1 = "i1 value1"
local i2 = Object:new()
i2.key1 = "i2 value1"
print(i1.key1);
print(i2.key1);

-- 继承
    -- subClass
function  Object:subClass(new_class)
    _G[new_class] = {}
    local class = _G[new_class]
    setmetatable(class, self)
    self.__index = self
    class.base = self
end

Object:subClass("People")
print(People.key1)
People.name = "PeopleName"
People:subClass("Student")

print("Student instance")
local stu1 = Student:new()
print(Student.key1)
print(Student.name)

-- 多态
    -- 方法实现和重写
function People:speak()
    self.name = self.name .. "|"
    print("People", self.name)
end

print("`````````People speak")
stu1.name = "stu1 name"
stu1:speak()

function  Student:speak()
    self.base.speak(self)
    print("Student", self.name)
end

print("`````````Student speak")
stu1.name = "stu1 name"
stu1:speak()