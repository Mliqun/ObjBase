using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase 
{
    public GameObject m_go;  // �洢��ǰ����
    public Vector3 m_local_pos;   //��ǰ�����ڱ��ص�λ��
    public Animator m_anim;
    public UIPate m_pate;
    public MonsterType m_type;

    public int m_insID;//ʵ��ID
    public string m_modelPath;  //ģ��·��

    public ObjectBase()
    {

    }
    // ��������ķ���
    public virtual void CreateObj(MonsterType type)
    {
        m_type = type;
        if (!string.IsNullOrEmpty(m_modelPath) && m_insID >= 0)
        {
            m_go = (GameObject)GameObject.Instantiate(Resources.Load(m_modelPath));
            m_go.name = m_insID.ToString();
            m_go.transform.position = m_local_pos;
            if (m_go)
            {
                OnCreate();
            }
        }
    }
    //�ڴ�����ʱ���ʼ�����߼�
    public virtual void OnCreate()
    {

    }
    //����λ��
    public virtual void SetPos(Vector3 pos)
    {
        m_local_pos = pos;
    }
    //�ƶ�
    public void MoveByTranslate(Vector3 look, Vector3 move)
    {
        //===TODO  ʹ��Navmeshʵ���ƶ�

        m_go.transform.LookAt(look);// �ƶ���ɫ�������λ�ã������������λ���ƶ���
        m_go.transform.Translate(move);
    }
    //�Զ��嶮
    public void AutoMove(Vector3 look, Vector3 move)
    {
        //TODO ��ʾ·����
        //TODO ֪ͨС��ͼ��ʾ·����

        MoveByTranslate(look, move);
    }
    // ��������ķ���
    public virtual void Destory()
    {
        if (m_pate)
        {
            GameObject.Destroy(m_pate);
        }
        GameObject.Destroy(m_go);
        m_local_pos = Vector3.zero;
        m_anim = null;
        m_insID = -1;
    }
}
