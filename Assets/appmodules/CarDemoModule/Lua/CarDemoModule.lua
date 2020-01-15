local CarDemoModule = Class.define("CarDemoModule",BaseModel);

function CarDemoModule:New(_csobj)
    self:super(CarDemoModule,"New", _csobj);
    self.MainViewComp = self:AddComp("MainViewComp",require "CarDemoModule.MainViewComp","MainViewComp")
end

return CarDemoModule;