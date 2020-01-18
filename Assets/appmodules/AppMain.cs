using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using u3d_fw;

public class AppMain : Main
{
    protected override void StartApp()
    {
        Manager_ManagerModel.Instance.StartModule<ResourceModule>((mpdule) =>
        {
            Manager_ManagerModel.Instance.StartModule<ViewManagerModule>(null,new Vector2(1920f,1080f));
            Manager_ManagerModel.Instance.StartModule<CarDemoModule>();
        });
    }
}
