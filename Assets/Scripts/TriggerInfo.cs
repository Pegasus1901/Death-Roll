using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInfo : MonoBehaviour
{
    public GameObject FD;
    public GameObject BD;
    [SerializeField]TriggerForExit exit;
    
    public void RandomNos(GameObject x, GameObject y)
    {
        FD = x;
        BD = y;
    }
    private void OnCollisionEnter()
    {
            FD.GetComponent<MeshRenderer>().enabled = true;
            FD.GetComponent<MeshCollider>().enabled = true;
            BD.GetComponent<MeshCollider>().enabled = true;
            BD.GetComponent<MeshCollider>().enabled = true;
    }
}
