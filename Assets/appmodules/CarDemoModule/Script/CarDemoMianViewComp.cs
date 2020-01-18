using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using u3d_fw;
using UnityEngine.UI;

public class CarDemoMianViewComp : Model_BaseViewComp<CarDemoModule>
{

    private Button demobutt;
    public override void Load(ModelBase module, params object[] agr)
    {
        base.Load(module, "MianViewComp");
        demobutt = UIGameobject.OnSubmit<Button>("demobutt");
        demobutt.onClick.AddListener(demobuttClick);
    }

    private void demobuttClick() {
        Debug.Log("liwei1dao");
    }
 }
