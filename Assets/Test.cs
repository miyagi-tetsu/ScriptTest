using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{

	private int hp = 100;
	private int power = 25;

    //発展課題_s
	private int mp = 53;

		public void Magic() {
		if (mp >= 5) {
			Debug.Log ("魔法攻撃をした。残りMPは" + (mp = mp - 5));
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
	//発展課題_e

		public void Attack() {
		Debug.Log (this.power + "のダメージを与えた");

	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージ受けた");
		this.hp -= damage;
	}
}
	
public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {

//課題配列_s
		//課題回答：要素5個の宣言＆初期化  
		int[] array = { 1, 3, 5, 7, 9 };

		Debug.Log ("課題回答：要素の表示");
		Debug.Log(array [0]);
		Debug.Log(array [1]);
		Debug.Log(array [2]);
		Debug.Log(array [3]);
		Debug.Log(array [4]);

		Debug.Log("課題回答：for文での逆表示");
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array [i]); 
		}

//課題配列_e
			Boss lastboss = new Boss ();

			lastboss.Attack ();

			lastboss.Defence (3);

		//発展課題_s
		for (int a = 10; a >= 0; a--) {
			lastboss.Magic ();
		}
		//発展課題_e			

	}
	
	
	// Update is called once per frame
	void Update () {
	
	}

}

