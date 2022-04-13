using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema5 : MonoBehaviour
{
    public string producto1;
    public float precioProducto1;
    public int unidadesDeseadasProd1;
    public string producto2;
    public float precioProducto2;
    public int unidadesDeseadasProd2;
    public string producto3;
    public float precioProducto3;
    public int unidadesDeseadasProd3;

    float PrecioProd1ConDescuento;
    float PrecioProd2ConDescuento;
    float PrecioProd3ConDescuento;

    float descuentoProd1;
    float descuentoProd2;
    float descuentoProd3;

    float montoSinDescuento;
    float montoConDescuento;
    float montoTotalDeDescuento;
    // Start is called before the first frame update
    void Start()
    {
        montoSinDescuento = precioProducto1 + precioProducto2 + precioProducto3;

        

        if (unidadesDeseadasProd1 < 1 || precioProducto1 < 1 || unidadesDeseadasProd2 < 1 || precioProducto2 < 1 || unidadesDeseadasProd3 < 1 || precioProducto3 < 1)
        {
            Debug.Log("Error descriptivo");
        }

        else
        {
            if (unidadesDeseadasProd1 > 3) 
            {
                PrecioProd1ConDescuento = precioProducto1 / 100 * 20;
                
            }

            if (unidadesDeseadasProd2 > 3)
            {
                PrecioProd2ConDescuento = precioProducto2 / 100 * 20;
            }
            if (unidadesDeseadasProd3 < 3)
            {
                PrecioProd3ConDescuento = precioProducto3 / 100 * 20;
            } 

            montoConDescuento = PrecioProd1ConDescuento + PrecioProd2ConDescuento + PrecioProd3ConDescuento;

            montoTotalDeDescuento = montoSinDescuento - montoConDescuento;  

            Debug.Log("Monto total sin descuento: " + montoSinDescuento);
            Debug.Log("Monto total de los descuentos aplicados: " + montoTotalDeDescuento);
            Debug.Log("Monto total con  descuentos aplicados: " + montoConDescuento);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
