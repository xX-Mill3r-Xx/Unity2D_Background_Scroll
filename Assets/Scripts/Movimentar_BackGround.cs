using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentar_BackGround : MonoBehaviour
{
    //O deslocamento de uma imagem usa diretamente o Mesh render, por isso precisamos trabalhar nesta variavel
    Renderer mesh;

    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Aqui, passamos a variavel para o componente Mesh Render onde contem a imagem;
        mesh = GetComponent<Renderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 offset = new Vector2(speed * Time.deltaTime, 0);
        mesh.material.mainTextureOffset += offset;
    }
}
