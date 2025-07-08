using UnityEngine;

public class Vibration_JY : MonoBehaviour
{
    public CameraShaker_JY cameraShaker;

    void Start()
    {
        Invoke(nameof(ShakeIt), 2f);    // 2초 뒤에 실행
    }

    void ShakeIt()
    {
        cameraShaker.TriggerShake(7f, 0.15f);
    }
}
