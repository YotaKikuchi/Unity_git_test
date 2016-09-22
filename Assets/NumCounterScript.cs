using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumCounterScript : MonoBehaviour {

	Text numText;
	int initNum = 0;
	int currentNum;

	// Use this for initialization
	void Start () {
		numText = this.GetComponent<Text>();
		UpdataText(initNum);
		currentNum = initNum;
	}

	void UpdataText(int n){
		numText.text = n.ToString();
	}

	public void AddNum(int n){
		currentNum += n;
		UpdataText(currentNum);
	}

}
