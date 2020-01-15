using u3d_fw;
public class CarDemoModule : ManagerContorBase<CarDemoModule>
{

    private CarDemoMianViewComp MianViewComp;
    public override void Load(params object[] agr)
    {
        ResourceComp = AddComp<Module_ResourceComp>();
        MianViewComp = AddComp<CarDemoMianViewComp>();
        base.Load(agr);
    }

}
