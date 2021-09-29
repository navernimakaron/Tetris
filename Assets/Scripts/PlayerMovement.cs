using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMove
{
    [SerializeField] float _horizontal;

    [SerializeField] float _speed = 2f;
    void Start()
    {
        transform.position = new Vector3(0.33f, -3.77f, 0f);
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        //Moves the player left and right multiplied by _speed parameter
        _horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        gameObject.transform.Translate(_horizontal, 0f, 0f);
    }
}