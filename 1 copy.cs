using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public string baseName;
    public int startValue = 1;

    private int currentValue;

    public void Spawn()
    {
        string newName = baseName + currentValue.ToString();
        GameObject newObject = Instantiate(objectToSpawn, transform.position, transform.rotation);
        newObject.name = newName;
        currentValue++;
    }

    void Start()
    {
        currentValue = startValue;
    }
}