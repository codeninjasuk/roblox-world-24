local ChatService = game:GetService("Chat")
local head = script.Parent.Head
local prompt = head.ProximityPrompt
local chatList = {"Hello, I'm Sensei Matt!", "Hi-Yah!"}
prompt.Triggered:Connect(function()
ChatService:Chat(head, chatList[math.random(1, #chatList)])
end)
