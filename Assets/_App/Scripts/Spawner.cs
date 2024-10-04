using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public static Spawner Instance { get; private set; }

    public GameObject RedPlane;
    private Vector3 missilePosition;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setMissilePosition(Vector3 missilePos){
        this.missilePosition = missilePos;

    }

    public void spawnPlane(GameObject plane){
    // empty object to work with the transfrom
    GameObject planeSpawnPoint = new GameObject();


    // random height for the plane
    // assign a random value between (range) 0.5f, 1.5f
    float extraHeight = Random.Range(0.5f, 1.5f);


    // random depth for the plane's Z axis
    // same, assign a random value between .5f, 1.5f
    float extraDepth = Random.Range(0.5f, 1.5f);

    // plane position
    Vector3 planeSpawnPosition = new Vector3(.0f, this.missilePosition.y + extraHeight, this.missilePosition.z + extraDepth);

    // set the position of the spawn
    planeSpawnPoint.transform.position = planeSpawnPosition;

    // instanciate a plane at the spawn position
    Instantiate(plane, planeSpawnPoint.transform);

    }

    public void spawnRedPlane(){
        spawnPlane(this.RedPlane);
    }
    public void spawnGreenPlane(){
        
    }
    public void spawnRainbowPlane(){
        
    }
}
