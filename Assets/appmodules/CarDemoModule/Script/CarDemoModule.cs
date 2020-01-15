using u3d_fw;
using UnityEngine;
public class CarDemoModule : ManagerContorBase<CarDemoModule>
{
    [u3dfw_Serialize]
    private string demostr1 = "hello";

    [u3dfw_SerializeName("我是 hello2")]
    private string demostr2 = "hello";

    public override void Load(params object[] agr)
    {
        base.Load(agr);
    }


    public override void ShowInspector() {
        GUILayout.BeginVertical();
        GUILayout.Label("liwei1dao");
        if (GUILayout.Button("按钮")) {
            Debug.Log("测试自定义属性面板");
        }
        GUILayout.EndVertical();
    }

}
