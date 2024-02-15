using UnityEngine;
using Cinemachine;
[System.Serializable]
public class TankController
{
    private TankView tankView;
    private TankModel tankModel;

    private Rigidbody rigidbody;

    public TankController(TankView tankView, TankModel tankModel, CinemachineTargetGroup cinemachineTargetGroup)
    {
        TankView tankV = Object.Instantiate(tankView);
        this.tankView = tankV;
        this.tankModel = tankModel;

        rigidbody = tankV.rb;
        cinemachineTargetGroup.AddMember(tankV.transform,1,6);  
        tankV.SetTankController(this);
        tankModel.SetTankController(this);

        tankV.SetMaterial(tankModel.material);
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
