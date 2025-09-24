using UnityEngine;

public class PoolObjectSpawner : MonoBehaviour
{
    public GameObject SpawnObject(string objectTag, Transform location)
    {
        GameObject obj = ObjectPooling.SharedInstance.GetPooledObject(objectTag);
        if (obj != null)
        {
            obj.transform.position = location.position;
            obj.transform.rotation = location.rotation;
            obj.SetActive(true);
            return obj;
        }
        return null;
    }

    public void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
    }
}
