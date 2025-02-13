using UnityEngine;

public class CustomDarts : MonoBehaviour
{
    [Tooltip("The object that will be spawned")]
    public GameObject prefab = null;
    [Tooltip("The transform where the object is spawned")]
    public Transform spawnTransform = null;

    public void Spawn() {
        //create dart
        GameObject dart = Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
        //set launch speed
        float launchSpeed = 4.5f;
        //create Vector3 to represent forawrd force
        Vector3 force = spawnTransform.forward * launchSpeed;
        dart.GetComponent<Rigidbody>().AddForce(force);
    }
}
