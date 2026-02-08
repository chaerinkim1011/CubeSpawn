using UnityEngine;
using System.Collections;
public class Spawner : MonoBehaviour
{
    public GameObject cube; //만들 큐브
    public IEnumerator SpawnCube()
    {
        float elapsedTime = 0f; //스폰 시작 후 흐른 시간

        while (elapsedTime < 10f) //10초 동안 반복
        {
            //랜덤하게 위치 생성
            float x = Random.Range(0f, 10f);
            float y = Random.Range(0f, 10f);
            Vector3 pos = new Vector3(x, y, 0f);

            //큐브 생성
            Instantiate(cube, pos, Quaternion.identity);

            yield return new WaitForSeconds(0.5f); //0.5초 대기
            elapsedTime += 0.5f; //흐른 시간 누적
        }
    }
}
