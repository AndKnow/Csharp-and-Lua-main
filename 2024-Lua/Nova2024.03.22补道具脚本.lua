local setting = require 'setting'
local mdl_backpack = require 'model.backpack'
local cjson = require 'cjson'

setting:connect_default_redis()
setting:set_randomseed()

-- 读取 json 文件
local file_name = "Nova2024.03.22补道具记录内玩"
local player_id_2_item_num = {}
local json_data = cjson.decode(io.open(file_name):read("*all"))

for _, data in ipairs(json_data) do
    local player_id = tonumber(data['player_id']) or 0
    local change_num = math.abs(tonumber(data['change_num']) or 0)
    player_id_2_item_num[player_id] = change_num
end

-- for player_id, change_num in pairs(player_id_2_item_num) do
--     print("player_id", player_id)
    -- print("change_num", change_num)
-- end

local item_id = 22212302

for player_id, change_num in pairs(player_id_2_item_num) do
    local m_backpack = mdl_backpack:new(player_id)
    if m_backpack and player_id and player_id ~= 0 and change_num and change_num > 0 then
        m_backpack:add_items({
            {
                item_id = item_id,
                item_num = change_num
            }
        })
    end
end


local crequest = require 'controller.request'
crequest.after({})
local lib_xlog = require 'lib.sys.xlog'
xlog:query()
lob_xlog.close_all_database()