using UnityEngine;
using UnityEngine.UI;

public class CoinPicker : MonoBehaviour {

    private int score;
    public Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + ": collected a " + gameObject.name);

        Value value = other.GetComponent<Value>();
        if(value!= null)
        {
            score += value.value;
            scoreText.text = score.ToString();
        }

        Destroy(other.gameObject);
    }
}
