using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    [SerializeField] private float rotationSpeed = 10f;

    

    [SerializeField] private GameInput gameInput;

    private bool Runing;
    public bool runing() { return Runing; }

  
    private void Update()
    {

        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x,0f ,inputVector.y);

        Runing = moveDir != Vector3.zero;

        transform.forward = Vector3.Slerp(transform.forward , moveDir ,rotationSpeed * Time.deltaTime);

        transform.position += moveSpeed * moveDir * Time.deltaTime;

        Debug.Log(inputVector);
    }
}
