using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CustomAvatarInputConverter : MonoBehaviour
{
    //Avatar Transforms
    public Transform mainAvatarTransform;
    public Transform avatarHead;
    public Transform avatarBody;

    public Transform avatarHand_R;
    public Transform avatarHand_L;

    public Transform oculusHand_R;
    public Transform oculusHand_L;

    
    //Oculus Player Transforms
    public Transform oculusHead;

    

    public Vector3 posOffset;
    public Vector3 rotOffset;

    public Vector3 headBodyOffset;
    private void Start()
    {
        headBodyOffset = avatarHead.position - avatarBody.position;
     
    }


    // Update is called once per frame
    void Update()
    {
        mainAvatarTransform.position = Vector3.Lerp(mainAvatarTransform.position, oculusHead.position, 0.2f)+posOffset;
       
        avatarHead.rotation = Quaternion.Lerp(avatarHead.rotation, oculusHead.rotation, 0.2f);

        avatarBody.rotation = Quaternion.Euler(new Vector3(0, avatarHead.rotation.eulerAngles.y, 0));


        avatarHand_R.position = Vector3.Lerp(avatarHand_R.position, oculusHand_R.position, 0.2f);
        avatarHand_R.rotation = Quaternion.Lerp(avatarHand_R.rotation, oculusHand_R.rotation, 0.2f);


        avatarHand_L.position = Vector3.Lerp(avatarHand_L.position, oculusHand_L.position, 0.2f); 
        avatarHand_L.rotation = Quaternion.Lerp(avatarHand_L.rotation, oculusHand_L.rotation, 0.2f);

    }
}
