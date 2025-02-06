using UnityEngine;

public class CustomBubbles : MonoBehaviour
{
    [Tooltip("The object that will be spawned")]
    public GameObject prefab = null;
    [Tooltip("The transform where the object is spawned")]
    public Transform spawnTransform = null;
    
    public void Spawn() {
        //create bubble
        GameObject bubble = Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
        //rotate randomly
        bubble.transform.rotation = Random.rotation;
        //set randomised launch speed
        float launchSpeed = Random.Range(0.5f, 1.5f);
        //create Vector3 to represent forawrd force
        Vector3 force = spawnTransform.forward * launchSpeed;
        bubble.GetComponent<Rigidbody>().AddForce(force);
        bubble.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
    }
}
