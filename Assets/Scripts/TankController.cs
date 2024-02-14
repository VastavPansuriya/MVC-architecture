using UnityEngine;

[System.Serializable]
public class TankController
{
    private TankView tankView;
    private TankModel tankModel;

    private Rigidbody rigidbody;

    public TankController(TankView tankView, TankModel tankModel)
    {
        TankView tankV = Object.Instantiate(tankView);
        this.tankView = tankV;
        this.tankModel = tankModel;

        rigidbody = tankV.rb;

        tankV.SetTankController(this);
        tankModel.SetTankController(this);
    }

    public void Move(float movement, float speed)
    {
        rigidbody.velocity = movement * speed * tankView.transform.forward;
    }
        
    public void Rotate(float rotate, float speed)
    {
        Vector3 rot = new Vector3(0, rotate * speed, 0f);
        Quaternion finalRot = Quaternion.Euler(rot * Time.deltaTime);
        rigidbody.MoveRotation(rigidbody.rotation * finalRot);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
