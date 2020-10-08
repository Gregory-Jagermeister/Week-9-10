using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {
  void Start () {

  }

  void Update () {

  }

  void OnTriggerEnter2D (Collider2D col) {
    Scorekeeper.Instance.AddScore ();
    Destroy (gameObject);
  }
}