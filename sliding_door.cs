local door = script.Parent
local location = door.Parent.Placeholder
local state = "closed"
local ts = game: GetService("TweenService")
local info = TweenInfo.new()
local close = ts: Create(door, info, {
  CFrame = door.CFrame
})
local open = ts: Create(door, info, {
  CFrame = location.CFrame
})
for i,
part in door.Parent: GetDescendants() do
if part: IsA("ProximityPrompt") then part.Triggered: Connect(function() door.trigger: Play() if state == "open"
then
close: Play()
door.close: Play()
else open: Play() door.open: Play() end part.Enabled = false end) end end close.Completed: Connect(function() for i, part in door.Parent: GetDescendants() do
if part: IsA("ProximityPrompt") then part.Enabled = true state = "closed"
end
end
end)
open.Completed: Connect(function()
for i, part in door.Parent: GetDescendants() do
if part: IsA("ProximityPrompt") then part.Enabled = true state = "open"
end
end
end)
