using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.PostProcessing.SubpixelMorphologicalAntialiasing;

public class AmmoBox : MonoBehaviour
{
    RayShooter _rayShooter;
    [SerializeField] int quantityOfammunition=15;
    private void Start()
    {
        _rayShooter = FindObjectOfType<RayShooter>();
    }
    private void OnTriggerEnter(Collider other)
    {
        _rayShooter.ReplenishAmmunition(quantityOfammunition);
        Destroy(gameObject);
    }
}
