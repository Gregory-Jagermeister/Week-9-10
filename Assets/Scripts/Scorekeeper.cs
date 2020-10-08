using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
  private static Scorekeeper _instance;

  public int score { get; private set; }

  [SerializeField]
  private int points;
  public static Scorekeeper Instance
  {
    get
    {
      if (_instance == null)
      {
        _instance = GameObject.FindObjectOfType<Scorekeeper>();
      }

      return _instance;
    }
  }

  public void AddScore()
  {
    score += points;
  }


  // Start is called before the first frame update
  void Start()
  {
    score = 0;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
