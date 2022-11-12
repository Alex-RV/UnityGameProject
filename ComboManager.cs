using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

enum ComboStage{
    NONE = 0,
    DOWN_1,
    DOWN_RIGHT_2,
    RIGHT_3

    // AXE_KICK_1,
    // AXE_KICK_2,
    // AXE_KICK_READY,
}

public class ComboManager : MonoBehaviour
{
    public float timeout = 0.25f;

    private ComboStage comboStage = ComboStage.NONE;
    private float timeLeft = 0.0f;
    private StarterAssetsInputs _input;


    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if(comboStage == ComboStage.NONE)
            {
                //check if DOWN is pressed
                if(_input.crouch && _input.move == Vector2.zero){
                    comboStage = ComboStage.DOWN_1;
                    timeLeft = timeout;
                }
            }
        else if(timeLeft > 0.0f)
        {
            timeLeft -= Time.deltaTime;

            if(timeLeft <= 0.0f){
            comboStage = ComboStage.NONE;
            }
            else if(comboStage == ComboStage.DOWN_1){
                //check if DOWN ans RIGHT is pressed
                if(_input.crouch && _input.move.x > 0.0f){
                    comboStage = ComboStage.DOWN_RIGHT_2;
                    timeLeft = timeout;
                }

            }else if(comboStage == ComboStage.DOWN_RIGHT_2){
                if(!_input.crouch && _input.move.x > 0.0f){
                    comboStage = ComboStage.RIGHT_3;
                    timeLeft = timeout;
                }

            }else if(comboStage == ComboStage.RIGHT_3){
                if(!_input.attack){
                    Debug.Log("AXE KICK!!!");
                    comboStage = ComboStage.NONE;
                    timeLeft = 0.0f;
                }
            }
        }
        
    }
}
