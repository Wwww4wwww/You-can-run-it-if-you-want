using UnityEngine;

public class FollowScript : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 5, -7);
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Смещение камеры
        transform.position = player.transform.position + offset;
    }
}
