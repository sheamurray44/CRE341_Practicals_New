using System;
using UnityEngine;
using UnityEngine.AI;

public class StateMachine_Practical : MonoBehaviour
{
    public GameObject npc;
    public GameObject player;
    public State currentState;

    [SerializeField] private float playerDistance;
    //[SerializeField] private bool playerIsVisible;
    private void Start()
    {
        currentState = State.Searching;
        //playerIsVisible = true;
    }
    private void Update()
    {
        //CheckPlayerDistance();

        switch (currentState)
        {
            case State.Searching:
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ChangeStateTo(State.Moving);
                }
                Debug.Log("Looking for player");
                SearchingPlayer();
                break;

            case State.Moving:
                if (Input.GetKeyDown(KeyCode.R))
                {
                    ChangeStateTo(State.Searching);
                }
                Debug.Log("Going to the player");
                MovingToPlayer();
                break;

        }
    }
    public enum State
    {
        Searching,
        Moving
    }
    public void SearchingPlayer()
    {
            Debug.Log("Doing nothing");
    }

    public void MovingToPlayer()
    { 
        npc.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
    }
    float CheckPlayerDistance()
    {
        playerDistance = Vector3.Distance(player.transform.position, transform.position);
        return playerDistance;
    }

    private void ChangeStateTo(State newState)
    {
        currentState = newState;
    }
}
