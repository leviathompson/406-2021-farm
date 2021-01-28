using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{

    public float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyTimer());
    }


    private IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(this.gameObject);
    }

}
