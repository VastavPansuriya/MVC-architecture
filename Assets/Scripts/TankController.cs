using UnityEngine;

public class TankController
{
    private TankView tankView;
    private TankModel tankModel;

    public TankController(TankView tankView, TankModel tankModel)
    {
        TankView tankV = GameObject.Instantiate(tankView);

        this.tankView = tankV;
        this.tankModel = tankModel;

        tankView.SetTankController(this);
        tankModel.SetTankController(this);
    }
}
