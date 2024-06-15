//Desarrollado por Frank Aguilar Garzon y Juan Pablo Pinzon Delgado

using notasEstudiante;
using System;

public class CalcularNotas
{
    public double CalcularNotaDefinitiva(double notaCorte1, double notaCorte2, double notaCorte3)
    {
        return (notaCorte1 * 0.35) + (notaCorte2 * 0.35) + (notaCorte3 * 0.30);
    }
}
