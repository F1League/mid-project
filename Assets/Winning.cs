using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winning : MonoBehaviour
    
{
    public GameObject youWInText;
void Start()
{

}
void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag=="Player")
    {
        youWInText.SetActive(true);
    }
}
    
}
