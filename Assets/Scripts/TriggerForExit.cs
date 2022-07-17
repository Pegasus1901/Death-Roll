using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForExit : MonoBehaviour
{
    public GameObject door;
    public GameObject BackDoor;
    TriggerInfo triggerInfo;
    public int a;
    void Start()
    {
        RandomNumber();
    }

    public void RandomNumber()
    {
        int r = Random.Range(1, 7);
        a = r;
        PathOpeningScript(r);
        triggerInfo.StoreRes(a);
    }
    
    public void PathOpeningScript(int rand)
    {
        
        switch (rand)
        {
            case 1:
                door = GameObject.FindGameObjectWithTag("01");
                BackDoor = GameObject.FindGameObjectWithTag("b1");
                break;
            case 2:
                door = GameObject.FindGameObjectWithTag("02");
                BackDoor = GameObject.FindGameObjectWithTag("b2");
                break;
            case 3:
                door = GameObject.FindGameObjectWithTag("03");
                BackDoor = GameObject.FindGameObjectWithTag("b3");
                break;
            case 4:
                door = GameObject.FindGameObjectWithTag("04");
                BackDoor = GameObject.FindGameObjectWithTag("b4");
                break;
            case 5:
                door = GameObject.FindGameObjectWithTag("05");
                BackDoor = GameObject.FindGameObjectWithTag("b5");
                break;
            case 6:
                door = GameObject.FindGameObjectWithTag("06");
                BackDoor = GameObject.FindGameObjectWithTag("b6");
                break;
        }

        MeshRenderer meshValue= door.GetComponent<MeshRenderer>();
        MeshRenderer backMesh = BackDoor.GetComponent<MeshRenderer>();
        MeshCollider collider = door.GetComponent<MeshCollider>();
        MeshCollider backCollider = BackDoor.GetComponent<MeshCollider>();
        collider.enabled = false;
        meshValue.enabled = false;
        backCollider.enabled = false;
        backMesh.enabled = false;
    }

}
