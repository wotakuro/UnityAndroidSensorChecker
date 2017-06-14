using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using StrOpe = StringOperationUtil.OptimizedStringOperation;

public class SensorChecker : MonoBehaviour {
    public UnityEngine.UI.Text text;

    private int cnt = 0;
    private int idx = 0;
	// Use this for initialization
	void Start () {
        using (AndroidJavaClass jc = new AndroidJavaClass("com.utj.sensor.SensorWrapper"))
        {
            jc.CallStatic("init");
            cnt = jc.CallStatic<int>("getSensorCount");
        }
    }
	void Update () {
        text.text = "Sensor";
        try
        {
            using (AndroidJavaClass jc = new AndroidJavaClass("com.utj.sensor.SensorWrapper"))
            {
                float power = jc.CallStatic<float>("getPower", idx);
                int mode = jc.CallStatic<int>("getReportingMode", idx);
                int min = jc.CallStatic<int>("getMinDelay", idx);
                int max = jc.CallStatic<int>("getMaxDelay", idx);
                bool isWakeup = jc.CallStatic<bool>("isWakeUpSensor", idx);

                string defaultAccSensor = jc.CallStatic<string>("getDefaultAccSensor" );
                string name = jc.CallStatic<string>("getSensorName", idx);

                text.text = StrOpe.i + idx + "/" + cnt + "\n" + "DefaultAcc:" + defaultAccSensor + "\n\n" + "name:" +
                    name + "\n" + "power:" + power + "\n" + "mode:" + mode
                    + "\n" + "Delay:" + min
                    + " - " + max
                    + "\n" + "isWakeup:" + isWakeup;
            }
        }
        catch (System.Exception e)
        {
            text.text = e.ToString();
        }
	}
    public void Next()
    {
        ++idx;
        idx %= cnt;
    }
    public void Back()
    {
        --idx;
        if (idx < 0)
        {
            idx = cnt - 1;
        }
    }
}
