using UnityEngine;

public class NarutoSkill : MonoBehaviour
{
    public GameObject rasen1Prefab;
    public GameObject rasen2Prefab;
    public GameObject rasen3Prefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

    private GameObject currentRasen;

    public void ClearRasen()
    {
        if (currentRasen != null)
        {
            Destroy(currentRasen);
        }
    }

    public void SpawnRasen1()
    {
        ClearRasen();
        currentRasen = Instantiate(rasen1Prefab, spawnPoint1.position, Quaternion.identity);
        Destroy(currentRasen, 0.5f);
    }

        public void SpawnRasen2()
    {
        ClearRasen();
        currentRasen = Instantiate(rasen2Prefab, spawnPoint2.position, Quaternion.identity);
        Destroy(currentRasen, 0.5f);
    }

        public void SpawnRasen3()
    {
        ClearRasen();
        currentRasen = Instantiate(rasen3Prefab, spawnPoint3.position, Quaternion.identity);
        Destroy(currentRasen, 0.5f);
    }
}