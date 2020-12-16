using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TMP_Text scoreText;
    private float score = 0;
    public GameObject goal;
    public float goalDuration;
    public ParticleSystem goalFx;

    
    private void OnTriggerEnter(Collider other)
    {
        Ball ball = other.GetComponent<Ball>();
        if (ball != null)
        {
            other.transform.position = ball.spawnPosition;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            StartCoroutine(GoalApparition());
            score++;
            scoreText.text = score.ToString();
            goalFx.Emit(1000);
            
        }
        
    }

    IEnumerator GoalApparition()
    {
        goal.SetActive(true);
        yield return new WaitForSeconds(goalDuration);
        goal.SetActive(false);

    }
}
