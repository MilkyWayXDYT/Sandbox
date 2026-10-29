using UnityEngine;

public class DoorLogger : MonoBehaviour
{
    [SerializeField] private Door door;

    private void OnEnable() => door.Opened += HandleOpened;
    private void OnDisable() => door.Opened -= HandleOpened;

    private void HandleOpened(Door d) => Debug.Log($"{d.name} открылась");
}
