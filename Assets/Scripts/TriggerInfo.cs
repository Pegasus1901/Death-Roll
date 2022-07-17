using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInfo : MonoBehaviour
{
    public GameObject FD;
    public GameObject BD;
    TriggerForExit exit;
    public int b;
    
    public void StoreRes(int rd)
    {
        b = rd;
    }
    public void RandomNos(int x)
    {
        switch (x)
        {
            case 1:
                FD = GameObject.FindGameObjectWithTag("01");
                BD = GameObject.FindGameObjectWithTag("b1");
                break;
            case 2:
                FD = GameObject.FindGameObjectWithTag("02");
                BD = GameObject.FindGameObjectWithTag("b2");
                break;
            case 3:
                FD = GameObject.FindGameObjectWithTag("03");
                BD = GameObject.FindGameObjectWithTag("b3");
                break;
            case 4:
                FD = GameObject.FindGameObjectWithTag("04");
                BD = GameObject.FindGameObjectWithTag("b4");
                break;
            case 5:
                FD = GameObject.FindGameObjectWithTag("05");
                BD = GameObject.FindGameObjectWithTag("b5");
                break;
            case 6:
                FD = GameObject.FindGameObjectWithTag("06");
                BD = GameObject.FindGameObjectWithTag("b6");
                break;
        }
    }
    private void Start()
    {
        RandomNos(b);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MeshRenderer FMeshRender = FD.GetComponent<MeshRenderer>();
            MeshCollider FMeshCollider = FD.GetComponent<MeshCollider>();
            MeshCollider BMeshCollider = BD.GetComponent<MeshCollider>();
            MeshRenderer BMeshRender = BD.GetComponent<MeshRenderer>();
            FMeshCollider.enabled = true;
            FMeshRender.enabled = true;
            BMeshCollider.enabled = true;
            BMeshRender.enabled = true;
        }
    }
}
