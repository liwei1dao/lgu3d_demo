using lgu3d;

public class UmengDemoMainViewComp : Model_BaseViewComp<UmengDemoModule>
{
    public override void Load(ModelBase _ModelContorl, params object[] _Agr)
    {
        base.Load(_ModelContorl, "DemoMain");
        UIGameobject.OnAddClick("StartGameEvent",StartGameEvent);
        UIGameobject.OnAddClick("EndtGameEvent",EndtGameEvent);
        LoadEnd();
    }

    private void StartGameEvent (){
        UmengModule.Instance.Event("StartGameEvent");
    }

    private void EndtGameEvent (){
        UmengModule.Instance.Event("EndtGameEvent");
    }
}
