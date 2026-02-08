using System.Collections;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public TMP_Text startText; //카운트다운 표시
    public TMP_Text timerText; //10초 타이머 표시
    public GameObject ggText; //끝났을 때
    public Spawner spawner;

    void Start()
    {
        ggText.SetActive(false); //아직 GG 안 나오게 하기
        timerText.text = "Time 0";
        StartCoroutine(CountdownRoutine());
    }

    IEnumerator CountdownRoutine()
    {
        startText.text = "3";
        yield return new WaitForSeconds(1f);

        startText.text = "2";
        yield return new WaitForSeconds(1f);

        startText.text = "1";
        yield return new WaitForSeconds(1f);

        startText.text = ""; //카운트 끝나면 텍스트 숨기기

        Debug.Log("큐브 스폰을 시작합니다");

        //스폰 + 타이머 동시 시작
        StartCoroutine(spawner.SpawnCube());
        StartCoroutine(TimerRoutine());
    }

    IEnumerator TimerRoutine()
    {
        int time = 10; //타이머 초기값

        while (time >= 0) // 10 -> 0
        {
            timerText.text = $"Time {time}";
            yield return new WaitForSeconds(1f); //1초 대기
            time--; //1초씩 감소
        }

        ggText.SetActive(true); //끝나면 GG 표시됨
    }
}
