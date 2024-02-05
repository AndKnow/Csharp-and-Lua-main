local class1 = {}
function class1:data_plus(changed_value)
    self.data1 = self.data1 + (changed_value or 1)
    print("class1 func1, data1_plus =", self.data1)
end

function class1:new(value)
    local instance = {}
    instance.data1 = value or 0
    setmetatable(instance, {__index = class1})
    return instance
end

function class1.static_func()
    print("class1.static_func")
end

local class2 = {}
setmetatable(class2, {__index = class1})
local mt = {__index = class2}
function class2:new(init_value, value2)
    local o = class1:new(init_value)
    o.data2 = value2
    -- AI看这里,这里很奇怪,设置元表的话，不是在o没有找到函数的时候才找 calss2里面的函数吗
    -- 也就是说先找class1的函数，再找class2的函数才对，但是我调用data_plus之后，是出现了class2版本的data_plus
    -- (实际上o没有方法，o的方法也是通过元表得来的，但是这时候元表设置被覆盖了，先找了class2的函数，找不到再通过class2去找class1的函数)
    setmetatable(o, mt)
    return o
end

function class2:data_plus(changed_value)
    class1.data_plus(self, changed_value)
    self.data2 = self.data2 + (changed_value * 2 or 1)
    print("class2 func2, data_plus_2 =", self.data2) 
end

-- function class2.static_func()
--     print("class2.static_func")
-- end

local class1_instance1 = class1:new(10)
class1_instance1:data_plus(5);
class1_instance1:data_plus(20);
class1_instance1.static_func()

local class2_instance2 = class2:new(100,100)
class2_instance2:data_plus(10)
class2_instance2.static_func()

-- AI解释
-- 在你的代码中，class2的实例o的元表被设置了一次。具体过程如下：

-- 在class2的new方法中，首先调用了class1的new方法创建了一个实例o，这个实例的元表被设置为class1，这是第一次设置元表。
-- 然后在class2的new方法中，将这个实例o的元表重新设置为class2，这是第二次设置元表。
-- 所以，虽然在整个过程中元表被设置了两次，但实际上，对于class2的实例o来说，它的元表只被设置了一次，就是在class2的new方法中被设置为class2。

if class2_instance2.static_func then
    print("ok1")
end

if class2.static_func then
    print("ok1")
end