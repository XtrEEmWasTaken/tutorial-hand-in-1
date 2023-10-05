using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;

    private Vector2 _moveDir;

    // Start is called before the first frame update
    void Start()
    {
        InputManeger.init(myPlayer: this);
        InputManeger.GameMode();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)(_moveDir * speed * Time.deltaTime);
    }
    public void SetMovementDirection(Vector2 newDirection)
    {
        _moveDir = newDirection;
    }

}
