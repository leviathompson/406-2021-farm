using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderSystem : MonoBehaviour
{
    public Text orderText;
    public Image orderImage;
    public Text amountText;

    public List<string> produce;

    public int minOrderSize;
    public int maxOrderSize;
    
    // Start is called before the first frame update
    void Start()
    {
        LoadNewOrder();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            LoadNewOrder();
        }
    }

    private void LoadNewOrder() {
        int orderProduce = Random.Range(0, produce.Count);
        int orderSize = Random.Range(minOrderSize, maxOrderSize+1);

        orderText.text = produce[orderProduce];
        amountText.text = "  X " + orderSize;
    }
}
