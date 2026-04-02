//注意: 需要添加脚本编译宏 PROJECT_LOG_TEST_TEMP

using LowoUN.Util;
using UnityEngine;

public class Sample_Log : MonoBehaviour {
	[SerializeField] bool isDebug;
	void Start () {
		LLog.Init (isDebug);

		LLog.Error ("some error log");
		LLog.Warn ("some warning log");
		LLog.Log ("some normal debug log");
		LLog.Trace ("log util");

		LLog.Gray ("log asset");
		LLog.White ("log asset");
		LLog.Green ("log flow");
		LLog.Blue ("log data");
		LLog.Orange ("log test");
		LLog.Red ("log flow");

		LLog.Gray_Tag ("asset", "log asset");
		LLog.White_Tag ("asset", "log asset");
		LLog.Green_Tag ("flow", "log flow");
		LLog.Blue_Tag ("data", "log data");
		LLog.Orange_Tag ("test", "log test");
		LLog.Red_Tag ("flow", "log flow");
	}
}