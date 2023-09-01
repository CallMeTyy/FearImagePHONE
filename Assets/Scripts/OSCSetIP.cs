using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class OSCSetIP : MonoBehaviour
{
    [SerializeField] private OSCTransmitter transmitter;
    public void SetIPForTransmitter(string ip)
    {
        transmitter.RemoteHost = ip;
    }
}
