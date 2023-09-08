using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;
using System.Text;
using System;
using System.Text.RegularExpressions;

public class OSCSetIP : MonoBehaviour
{
    [SerializeField] private OSCTransmitter transmitter;
    public void SetIPForTransmitter(string ip)
    {
        ip = ip.ToUpper();
        if (Regex.IsMatch(ip, "([0-9]{1-3}){4}"))
        {
            transmitter.RemoteHost = ip;
            print(ip);
        }
        else if (Regex.IsMatch(ip, ".{4}-?.{4}"))
        {
            transmitter.RemoteHost = decode(ip);
            print(decode(ip));
        }
        else print("invalid code");
    }

    private string decode(string hexip)
    {
        hexip = hexip.Replace("-", "");
        byte[] raw = new byte[hexip.Length / 2];
        StringBuilder ip = new StringBuilder();
        for (int i = 0; i < raw.Length; i++)
        {
            raw[i] = Convert.ToByte(hexip.Substring(i * 2, 2), 16);
            ip.Append($"{raw[i]}.");
        }
        return ip.ToString().TrimEnd('.');
    }
}
