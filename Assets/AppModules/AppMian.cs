using lgu3d;
using UnityEngine;

public class AppMian : Main
{
    protected override void StartApp()
    {
        Manager_ManagerModel.Instance.StartModule<ResourceModule>((module)=>{
            Manager_ManagerModel.Instance.StartModule<ViewManagerModule>((module)=>{
                // Manager_ManagerModel.Instance.StartModule<PangolinAdvModule>();
                // Manager_ManagerModel.Instance.StartModule<PangolinAdvDomeModule>();
                Manager_ManagerModel.Instance.StartModule<UmengModule>();
                Manager_ManagerModel.Instance.StartModule<UmengDemoModule>();
            },new Vector2(1080,1920));
        });
    }
}
