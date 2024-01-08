local event_type = {}
setmetatable(event_type, {__index = function (t, key)
    t[key] = string.lower(key)
    return t[key]
end})

print(event_type.PLAYER_LOGIN)
for key, value in pairs(event_type) do
    print(value)
end