using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

    //vars para selecção
    public bool selected=false;

    //vars para movimentos
    private Vector3 moveToDest = Vector3.zero;
    public float floorOffSet = 1;

    private bool selectedByClick = false;


	void Update () 
    {        
        //se os obejectos estiverem dentro da box de slecção, determinada pela camera e se o botão estiver pressionado
        if (GetComponent<Renderer>() && Input.GetMouseButton(0))
        {
            if (!selectedByClick)
            {
                //retorna basicamente o que a camera ve como um colecção de pontos
                Vector3 camPos = Camera.main.WorldToScreenPoint(transform.position);
                //inverte a coordenada dos Y indo ao script CameraOperator          
                camPos.y = CameraOperator.InvertMouseY(camPos.y);        
                //se estiver contido na caixa de selecção, passa a true
                selected = CameraOperator.selection.Contains(camPos);
            }

            //caso seja seleccionado, a cor do objecto é modificada, caso contrário mantem o valor
            if (selected)
                GetComponent<Renderer>().material.color = Color.red;
            else
                GetComponent<Renderer>().material.color = Color.white;
        }   
        
        if (selected && Input.GetMouseButtonUp(1))
        {
            //Obtem o destino do click direito
            Vector3 destination = CameraOperator.GetDestination();

            //se o destino for um valor diferente de zero
            if (destination != Vector3.zero)
            {
                //inicia o pathing utilizand Navigation do Unity
                gameObject.GetComponent<NavMeshAgent>().SetDestination(destination);
            }
        }
    }

    private void OnMouseDown()
    {
        selectedByClick = true;
        selected = true;
    }

    private void OnMouseUp()
    {
        if (selectedByClick)
            selected = true;
            selectedByClick = false;

    }
}
