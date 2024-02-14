using UnityEngine;
using UnityEngine.UI;

public class LobbyUI : MonoBehaviour
{
    [SerializeField] private Button blue;
    [SerializeField] private Button green;
    [SerializeField] private Button red;

    [SerializeField] private TankSpawner tankSpawner;
    private void Start()
    {
        green.onClick.AddListener(() =>
        {
            tankSpawner.SpawnTank(TankType.Green);
            gameObject.SetActive(false);
        });

        blue.onClick.AddListener(() =>
        {
            tankSpawner.SpawnTank(TankType.Blue);
            gameObject.SetActive(false);
        });

        red.onClick.AddListener(() =>
        {
            tankSpawner.SpawnTank(TankType.Red);
            gameObject.SetActive(false);
        });
    }


}
