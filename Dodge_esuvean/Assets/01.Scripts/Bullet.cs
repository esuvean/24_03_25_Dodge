using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;      //�̵��� ����� ������ٵ� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        // ������ٵ��� �ӵ� = ������Ʈ�� �������� ���� ���� * �̵��ӷ�
        bulletRigidbody.velocity = transform.forward * speed;   

        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }

    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if(other.tag == "Player")
        {
            //���� ���� ������Ʈ���� Player_controller ������Ʈ ��������
            Player_controller player_Controller = other.GetComponent<Player_controller>();

            //�������κ��� Player_controller ������Ʈ�� �������� �� �����ߴٸ�
            if (player_Controller != null ) 
            {
                //���� Player_controller ������Ʈ�� Die() �޼��� ����
                player_Controller.Die();
            }
        } 
    }
}