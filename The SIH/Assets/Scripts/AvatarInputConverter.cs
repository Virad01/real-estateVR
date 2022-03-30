using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarInputConverter : MonoBehaviour
{


    //Avatar Transforms
    public Transform mainAvatarTransform;
    public Transform avatarHead;
    public Transform avatarBody;

    public Transform avatarHand_L;
    public Transform avatarHand_R;


    //Oculus Transforms
    public Transform oculusHead;

    public Transform oculusHand_R;
    public Transform oculusHand_L;


    public Vector3 posOffset;
   
    

    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        mainAvatarTransform.position = Vector3.Lerp(mainAvatarTransform.position, oculusHead.position +posOffset, 0.5f);

        avatarHead.rotation = Quaternion.Lerp(avatarHead.rotation, oculusHead.rotation, 0.5f);

        avatarBody.rotation = Quaternion.Lerp(avatarBody.rotation, Quaternion.Euler(new Vector3(0, avatarHead.rotation.eulerAngles.y, 0)),0.05f);


        avatarHand_R.position = Vector3.Lerp(avatarHand_R.position, oculusHand_R.position, 0.5f);
        avatarHand_R.rotation = Quaternion.Lerp(avatarHand_R.rotation, oculusHand_R.rotation, 0.5f);


        avatarHand_L.position = Vector3.Lerp(avatarHand_L.position, oculusHand_L.position, 0.5f);
        avatarHand_L.rotation = Quaternion.Lerp(avatarHand_L.rotation, oculusHand_L.rotation, 0.5f);
    }
}
