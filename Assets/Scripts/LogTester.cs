using UnityEngine;

public class LogTester : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Base Game Android đã khởi chạy thành công!");
        Debug.LogWarning("Đây là log cảnh báo (Warning) test thử.");
    }
    public void TestLogInfo()
    {
        Debug.Log("Log thông tin: Player đã bấm nút - " + Time.time);
    }
    public void TestLogError()
    {
        Debug.LogError("Log lỗi: NullReferenceException giả lập!");
    }
    public void TestSpamLog()
    {
        for(int i=0; i<10; i++)
        {
            Debug.Log($"Spam log dòng thứ {i}");
        }
    }
}