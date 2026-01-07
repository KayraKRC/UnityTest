using UnityEngine;

public class CompileTest : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Compile test başarılı");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space basıldı");
        }
    }
}

