using UnityEngine;

public class BedManager : MonoBehaviour
{
    public GameObject blueBed;
    public GameObject blackBed;
    public GameObject brownBed;
    public GameObject orangeBed;
    public GameObject pinkBed;

    private GameObject currentBed;

    private Vector3 spawnPos = new Vector3(-2f, 2.384186e-07f, -2.8f);
    private Vector3 spawnRot = new Vector3(0f, 90f, 0f);
    private Vector3 spawnScale = new Vector3(1.5f, 1.5f, 1.5f);

    void Start()
    {
        SpawnBed(blueBed);
    }

    public void SetBlue()  => SpawnBed(blueBed);
    public void SetBlack() => SpawnBed(blackBed);
    public void SetBrown() => SpawnBed(brownBed);
    public void SetOrange() => SpawnBed(orangeBed);
    public void SetPink() => SpawnBed(pinkBed);

    void SpawnBed(GameObject bedPrefab)
    {
        // 🔥 이전 오브젝트 완전 삭제
        if (currentBed != null)
        {
            Destroy(currentBed);
            currentBed = null;
        }

        // 새로 생성
        currentBed = Instantiate(bedPrefab);

        // 위치 / 회전 / 스케일 강제 적용
        currentBed.transform.position = spawnPos;
        currentBed.transform.rotation = Quaternion.Euler(spawnRot);
        currentBed.transform.localScale = spawnScale;
    }
}