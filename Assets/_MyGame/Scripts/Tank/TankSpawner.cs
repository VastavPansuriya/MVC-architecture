using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private CinemachineTargetGroup cinemachineTargetGroup;
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankType type;
        public Material tankMaterial;
    }

    [SerializeField] private TankView tankView;
    [SerializeField] private List<Tank> tankList = new List<Tank>();

    public void SpawnTank(TankType tankType)
    {
        Tank cuurTank = tankList[(int)tankType];
        TankModel tankModel = new TankModel(cuurTank.movementSpeed, cuurTank.rotationSpeed, cuurTank.type, cuurTank.tankMaterial);
        TankController tankController = new TankController(tankView,tankModel,cinemachineTargetGroup);
    }
}
