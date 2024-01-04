-- model包
local _M = {}
-- 成员
_M.field = "this is cainiao model field"

-- 函数
function _M:speak()
    print(self.field)
    print("CN-model, _M speak")
end

-- 返回
return _M