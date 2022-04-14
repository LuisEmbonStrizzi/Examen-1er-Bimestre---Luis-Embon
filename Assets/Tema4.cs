using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema4 : MonoBehaviour
{
    public int cantidadUnidades, cantidadDiasTotales, cantidadDeDiasLluvia;
    int costoTotalCombustible, diasNormales, litrosCombustibleNormal, litrosCombustibleLluvia, costoDiasNormalesCombustible, costoDiasLluviaCombustible;
    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDiasTotales < 5 || cantidadDeDiasLluvia < 0 || cantidadDeDiasLluvia >= cantidadDiasTotales) 
        {
            Debug.Log("La cantidad de días debe ser mayor a 5 o la cantidad de días de lluvia debe ser positiva o la cantidad de días de lluvia debe ser menor a la cantidad de dias totales");
        }
        else 
        {
            litrosCombustibleNormal = (cantidadUnidades * 90) / 15;
            litrosCombustibleLluvia = (cantidadUnidades * 120) / 15;

            diasNormales = cantidadDiasTotales - cantidadDeDiasLluvia;

            costoDiasLluviaCombustible = litrosCombustibleLluvia * (cantidadDeDiasLluvia * 130);

            costoDiasNormalesCombustible = litrosCombustibleNormal * (diasNormales * 130);

            costoTotalCombustible = costoDiasNormalesCombustible + costoDiasLluviaCombustible;

            Debug.Log("Una flota de " + cantidadUnidades + " unidades trabajando durante " + cantidadDiasTotales + " días implicará un gasto de " + costoTotalCombustible + " pesos en concepto de combustible");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
