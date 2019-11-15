using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGeneration : MonoBehaviour
{
    [SerializeField]
    public Transform[] startPos;
    [SerializeField]
    public GameObject[] Rooms;

    private int direction;
    public float moveAmount;

    private float timeBtwRoom;
    [SerializeField]
    private float startTimeBtwRoom = 0.25f;
    public float minY;
    public float maxX;
    public float minX;

    public bool endGen;//stoper la generation hauteur max du niveau

    public LayerMask RoomDetection;

    // Start is called before the first frame update
    void Start()
    {
        int randomPosition = Random.Range(0, startPos.Length);
        transform.position = startPos[randomPosition].position;
        transform.position = startPos[randomPosition].position;
        Instantiate(Rooms[0], transform.position, Quaternion.identity);

        direction = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwRoom <= 0 && endGen == false)
        {
            Move();
            timeBtwRoom = startTimeBtwRoom;
        }
        else
        {
            timeBtwRoom -= Time.deltaTime;
        }
    }

    private void Move()
    {

    }
    private void RightMove() { 
    
    }

    private void DownMove() { 
    
    }

    private void LeftMove()
    {
        
    }

    private void EndGen() { 
    }
}
