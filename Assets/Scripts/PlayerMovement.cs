using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMove
{
    [SerializeField] float _horizontal;
    [SerializeField] float _speed = 2f;
    private PlayerBoundaries _playerBoundaries;

    void Start()
    {
        transform.position = new Vector3(0.33f, -3.77f, 0f);
        _playerBoundaries = GetComponent<PlayerBoundaries>();
    }

    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        //Moves the player left and right multiplied by _speed parameter
        _horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        gameObject.transform.Translate(_horizontal, 0f, 0f);

        //Checks if IsBorder is false and does nothing if so
        if (!_playerBoundaries.IsBorder)
        {
            return;
        }
        //If IsBorder == true then run this 'else' code:
        else
        {
            //TODO: I need to stop and limit player's movement somehow
        }
    }
}