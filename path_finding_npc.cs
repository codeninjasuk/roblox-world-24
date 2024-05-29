local waypoints = game.Workspace.Waypoints
local npc = script.Parent:WaitForChild("Humanoid")
while true do
for waypoint = 1, #waypoints:GetChildren() - 1 do
npc:MoveTo(waypoints[waypoint].Position)
npc.MoveToFinished:Wait()
end
end
