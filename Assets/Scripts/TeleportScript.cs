using UnityEngine;
using System.Collections;
public class TeleportScript : MonoBehaviour
{
    public void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(5.0f, 15.0f);
        transform.position = pos;
    }
}
