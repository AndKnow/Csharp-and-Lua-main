-- 多脚本执行
local file_name = "TLS-MultiScript2"
local file_name2 = "TLS-MultiScript3"
local c = require(file_name)
local d = require(file_name2)
d()

-- 全局变量和本地变量
print(a)
print(b)
print(c)


-- 脚本卸载
    -- 重复加载
require(file_name)

    -- 判断
print("jug script has benn loaded?")
print(package.loaded[file_name])
package.loaded[file_name2]()

    -- 卸载
package.loaded[file_name2] = nil
require(file_name2)()

-- 大G表
print(_G["b"])
package.loaded[file_name] = nil
print(_G["b"])
