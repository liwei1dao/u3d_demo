using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using u3d_fw;

public class AppMain : Main
{
    protected override void StartApp()
    {
        base.StartApp();
        Manager_ManagerModel.Instance.StartModel<ResourceModule>((mpdule) =>
        {
            Manager_ManagerModel.Instance.StartModel<LuaManagerModule>();
        });
    }
}
