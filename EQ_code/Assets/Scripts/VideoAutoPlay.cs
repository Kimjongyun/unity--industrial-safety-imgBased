using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class VideoAutoPlay : MonoBehaviour
{
    private VideoPlayer video;

    void Start()
    {
        video = GetComponent<VideoPlayer>();
        StartCoroutine(PlayAndStopVideo());
    }

    private IEnumerator PlayAndStopVideo()
    {
        yield return new WaitForSeconds(9f); // 9초 대기 후 재생
        video.Play();
        yield return new WaitForSeconds(13f); // 재생 후 13초 뒤 정지
        video.Stop(); // 또는 video.Pause();

        GetComponent<Renderer>().material.color = Color.black; // 화면을 어둡게 처리
    }
}
