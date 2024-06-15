using System;

public class CalcularNotas
{
    public double CalcularNotaDefinitiva(double notaCorte1, double notaCorte2, double notaCorte3)
    {
        return (notaCorte1 * 0.35) + (notaCorte2 * 0.35) + (notaCorte3 * 0.30);
    }
}

//Server = localhost\SQLEXPRESS; Database = master; Trusted_Connection = True;