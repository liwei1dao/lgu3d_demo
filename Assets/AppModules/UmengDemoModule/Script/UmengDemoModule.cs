using lgu3d;
public class UmengDemoModule : ManagerContorBase<UmengDemoModule>
{
    private UmengDemoMainViewComp MainViewComp;
    public override void Load(params object[] agr)
    {
        ResourceComp = AddComp<Module_ResourceComp>();
        MainViewComp = AddComp<UmengDemoMainViewComp>();
        base.Load(agr);
    }
}
