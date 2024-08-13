using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBarrelRotation : MonoBehaviour
{
    void Update()
    {
        // Fare konumunu dünya koordinatlarına dönüştürme
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Z eksenini sıfırladığımızdan emin olun

        // Namlunun pozisyonunu al
        Vector3 barrelPosition = transform.position;

        // Fare konumuna doğru vektör oluştur
        Vector3 direction = mousePosition - barrelPosition;

        // Vektörü açıya dönüştür
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Namluyu döndür
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
