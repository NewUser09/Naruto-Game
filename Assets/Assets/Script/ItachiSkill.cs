using UnityEngine;

public class ItachiSkill : MonoBehaviour
{
    public GameObject katonPrefab;
    public Transform spawnPoint;
    private GameObject currentKaton;

    public void ClearKaton()
    {
        if (currentKaton != null)
        {
            Destroy(currentKaton);
        }
    }

    public void SpawnKaton()
    {
        ClearKaton();
        currentKaton = Instantiate(katonPrefab, spawnPoint.position, Quaternion.identity);
        Destroy(currentKaton, 0.5f);
    }
}