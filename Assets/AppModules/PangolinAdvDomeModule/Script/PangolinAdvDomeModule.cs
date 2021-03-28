
using lgu3d;
public class PangolinAdvDomeModule : ManagerContorBase<PangolinAdvDomeModule>
{
    private PangolinAdvDomeMainViewComp MainViewComp;
    public override void Load(params object[] agr)
    {
        ResourceComp = AddComp<Module_ResourceComp>();
        MainViewComp = AddComp<PangolinAdvDomeMainViewComp>();
        base.Load(agr);
    }

}
