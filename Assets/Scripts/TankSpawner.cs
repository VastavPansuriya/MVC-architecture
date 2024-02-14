using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
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
    private void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        Tank cuurTank = tankList[2];
        TankModel tankModel = new TankModel(cuurTank.movementSpeed, cuurTank.rotationSpeed, cuurTank.type, cuurTank.tankMaterial);
        TankController tankController = new TankController(tankView,tankModel);
    }
}
