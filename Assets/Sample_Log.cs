//注意: 需要添加脚本编译宏 PROJECT_LOG_TEST_TEMP

using LowoUN.Util;
using UnityEngine;

public class Sample_Log : MonoBehaviour {
	[SerializeField] bool isDebug;
	void Start () {
		LLog.Init (isDebug);

		// 只有在生产环境失效
		LLog.NOT_PRODUCTION_ERROR ("NOT_PRODUCTION_ERROR");
		LLog.NOT_PRODUCTION_WARN ("NOT_PRODUCTION_WARN");
		LLog.NOT_PRODUCTION_LOG ("NOT_PRODUCTION_LOG");

		// 只要非Editor环境就失效
		LLog.Error ("some error log");
		LLog.Warn ("some warning log");
		LLog.Log ("some normal debug log");

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