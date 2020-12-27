using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxExploetion : MonoBehaviour
{
    [SerializeField] private Box _box;
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    private Vector3 _center;

    private bool _tachBox;

    private void Start()
    {
        _center = _box.gameObject.transform.position;
    }
    private void OnEnable()
    {
        _box.Tach += Explosion;
    }

    private void OnDisable()
    {
        _box.Tach -= Explosion;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Objeckt" && _tachBox)
        {
            Rigidbody rigidbody = other.gameObject.GetComponent<Rigidbody>();
            Debug.Log(other.name);
            rigidbody.AddExplosionForce(_explosionForce, _center, _explosionRadius);
        }
    }

    private void Explosion()
    {
        _tachBox = true;

    }
}
