using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderSystem : MonoBehaviour
{
    public Text orderText;

    public List<string> produce;

    public int minOrderSize;
    public int maxOrderSize;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            SetNewOrder();
        }
    }

    private void SetNewOrder() {
        int orderProduce = Random.Range(0, produce.Count);
        int orderSize = Random.Range(minOrderSize, maxOrderSize);

        orderText.text = produce[orderProduce] + ": " + orderSize;
    }
}
