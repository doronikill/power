using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float powerGain = 10f;
    public float maxPower = 100f;

    public float _currentPower = 0f;
    bool _casting = false;

    void Update()
    {
        if (Imput.GetKeyDown(KeyCode.Mouse0))
        {
            Dubug.Log("start cast")
            _casting = true;
            _currentPower = 0f;
        }
        if (Imput.GetKey(KeyCode.Mouse0) && _casting)
        {
            Dubug.Log("casting")
            _currentPower += powerGain * Time.deltaTime;
            if (_currentPower > maxPower)
                _currentPower = maxPower;
        }
        if (input.GetKeyUp(KeyCode.Mouse0) && _casting)
        {
            Debug.Log("end cast");
            Shoot();
        }
    }

    void Shoot()
    {
        Dubug.Log(_currentPower)
        _casting = true;
        _currentPower = 0f;

    }
}
