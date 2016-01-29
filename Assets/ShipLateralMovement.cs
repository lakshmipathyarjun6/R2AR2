using UnityEngine;
using System.Collections;

public class ShipLateralMovement : MonoBehaviour {
    void Update() {
        transform.Translate(Time.deltaTime, 0, 0, Camera.main.transform);
    }
}