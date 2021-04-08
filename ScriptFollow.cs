using UnityEngine;

public class ScriptFollow : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position);
    }
}
