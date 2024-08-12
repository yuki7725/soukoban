using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //�����܂łɂ����鎞��
    private float timeTaken = 0.2f;
    //�o�ߎ���
    private float timeErapsed;
    //�ړI�n
    private Vector3 destination;
    //�o���n
    private Vector3 origin;

    // Start is called before the first frame update
    private void Start()
    {
        destination = transform.position;
        origin=destination;
    }


    public void MoveTo(Vector3 newDestination)
    {
        //�o�ߎ��Ԃ�������
        timeErapsed = 0;
        //�ړI�n���
        origin=destination;
        transform.position = origin;

        //�V�����ړI�n���
        destination= newDestination;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (origin == destination)
        {
            return;
        }

        timeErapsed += Time.deltaTime;
        float timeRate=timeErapsed/timeTaken;

        if (timeRate > 1) 
        {
            timeRate = 1;
        }

        float easing = timeRate;
        Vector3 currentPosition=Vector3.Lerp(origin, destination, easing);
        transform.position = currentPosition;
    } 
}
