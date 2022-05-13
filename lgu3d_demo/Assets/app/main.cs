using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using lgu3d;

public class main : Main
{
  protected override void StartApp()
  {
    Manager_ManagerModel.Instance.StartModule<ViewManagerModule>((module) =>
    {
      Manager_ManagerModel.Instance.StartModule<ResourceModule>((module) =>
      {
        Manager_ManagerModel.Instance.StartModule<TimerModule>();
        Manager_ManagerModel.Instance.StartModule<CoroutineModule>();
        Manager_ManagerModel.Instance.StartModule<EventModule>();
        Manager_ManagerModel.Instance.StartModule<SoundModule>();
        Manager_ManagerModel.Instance.StartModule<LanguageModule>(null, LanguageType.EN);
        Manager_ManagerModel.Instance.StartModule<SceneModule>();
        Manager_ManagerModel.Instance.StartModule<CommonModule>();

      }, new ResLoadViewComp());
    }, new Vector2(1080, 1920), 0f);
  }
}
