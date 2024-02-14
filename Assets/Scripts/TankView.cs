using UnityEngine;


public class TankView : MonoBehaviour
{
    private TankController tankController;

    public Rigidbody rb;

    private float movement;
    private float rotation;

    public MeshRenderer[] parts;

    private void Start()
    {
        Transform cm = Camera.main.transform;
        cm.SetParent(transform);
        cm.position = new Vector3(0,6,-11);
        cm.eulerAngles = new Vector3(10,0,0);
    }

    private void Update()
    {
        GetInput();

        if (movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }

        if (rotation != 0)
        {
            tankController.Rotate(rotation,tankController.GetTankModel().rotationSpeed);
        }
    }

    private void GetInput()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController tankController)
    {   
        this.tankController = tankController;
    }

    public Rigidbody GetRigidbody()
    {
        Debug.Log(rb);
        return rb;
    }

    public void SetMaterial(Material material)
    {
        foreach (var part in parts)
        {
            part.material = material;
        }
    }
}
