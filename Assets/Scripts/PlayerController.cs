using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Vector3 _initialPosition; //Initial Player Position
    private Vector3 _targetPosition; //Target Player Position
    private float _step;

    private Ray _ray;
    private RaycastHit _hit;

    void Start()
    {
        _targetPosition = transform.position;
    }

    void FixedUpdate()
    {
        _step = speed * Time.deltaTime;

        if(Input.GetButtonDown("Fire1"))
        {
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Casts the ray and get the board game object hit
            if(Physics.Raycast(_ray, out _hit))
            {
                if(_hit.collider.tag == "Board")
                    _targetPosition = _hit.point;
            }
        }

        //Set the new player position 
        if (_targetPosition != null)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _step);
    }
}
