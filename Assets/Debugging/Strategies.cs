using UnityEngine;

public class Strategies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            //instantiate a prefab
            //at a x position that's increasing by 1 
            //at a y position that's increasing by 0.1
            //and 0 in z, no rotation

            float x = i; //shouldn't be 0
            Debug.Log(i + "/" + 10 + " = " + i / 10);
            float y = i / 10f; //shouldn't be 0
            Debug.Log("Y = " + y);
            float z = 0; //this one is fine

            Instantiate(prefab, new Vector3 (x, y, z), Quaternion.identity);
        }
    }

}
