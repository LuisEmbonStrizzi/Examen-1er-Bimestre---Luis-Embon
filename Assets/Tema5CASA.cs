using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema5CASA : MonoBehaviour
{
    public string producto1, producto2, producto3;
    public int precioProducto1, precioProducto2, precioProducto3;
    public int unidadesProducto1, unidadesProducto2, unidadesProducto3;

    int descuentoProd1 = 0, descuentoProd2 = 0, descuentoProd3 = 0, SindescuentoProd1, SindescuentoProd2, SindescuentoProd3, montoTotalSinDescuento, montoDeLosDecuentos, montoTotalConDescuentos;

    // Start is called before the first frame update
    void Start()
    {
        if (precioProducto1 < 1 || precioProducto2 < 1 || precioProducto3 < 1 || unidadesProducto1 < 1 || unidadesProducto2 < 1 || unidadesProducto2 < 1)
        {
            Debug.Log("El precio del producto y las unidades del producto deben ser mayor o igual a 1");
        }
        else 
        {
            montoTotalSinDescuento = (precioProducto1*unidadesProducto1) + (precioProducto2*unidadesProducto2) + (precioProducto3 * unidadesProducto3);

            if (unidadesProducto1 > 3) 
            {
                descuentoProd1 = (precioProducto1 * unidadesProducto1) / 100 * 20;
                SindescuentoProd1 = 0;
            }
            if (unidadesProducto2 > 3)
            {
                descuentoProd2 = (precioProducto2 * unidadesProducto2) / 100 * 20;
                SindescuentoProd2 = 0;
            }
            if (unidadesProducto3 > 3)
            {
                descuentoProd3 = (precioProducto3 * unidadesProducto3) / 100 * 20;
                SindescuentoProd3 = 0;
            }

            montoDeLosDecuentos = descuentoProd1 + descuentoProd2 + descuentoProd3 + SindescuentoProd1 + SindescuentoProd2 + SindescuentoProd3;
            montoTotalConDescuentos = montoTotalSinDescuento - montoDeLosDecuentos;

            Debug.Log("El monto total sin descuento es: $" + montoTotalSinDescuento);
            Debug.Log("El monto total de los descuentos aplicados es: $" + montoDeLosDecuentos);
            Debug.Log("El monto total con descuentos es: $" + montoTotalConDescuentos);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
