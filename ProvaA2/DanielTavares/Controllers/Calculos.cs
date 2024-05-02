namespace ProvaA2.Controllers;

public class Calculo
{
    public double CalcularFgts(double SalarioBruto)
    {
       return SalarioBruto * 0.8;
    }

    public double CalcularInss(double SalarioBruto)
    {
        if (SalarioBruto <= 1693.72)
        {
            return SalarioBruto * 0.8;
        }
        else if (SalarioBruto > 1693.73 && SalarioBruto <= 2822.90)
        {
            return SalarioBruto * 0.9;
        }
        else if (SalarioBruto > 2822.90 && SalarioBruto <= 5645.80)
        {
            return SalarioBruto * 0.11;
        }
        else if (SalarioBruto > 5645.81)
        {
            return 621.03;
        }
        return 0;
    }

    public double CalcularIrrf(double SalarioBruto)
    {
       if (SalarioBruto <= 1903.98)
        {
            return 0;
        }
        else if (SalarioBruto > 1903.98 && SalarioBruto <= 2826.65)
        {
            return SalarioBruto * 0.75;
        }
        else if (SalarioBruto > 2826.65 && SalarioBruto <= 3751.05)
        {
            return SalarioBruto * 0.15;
        }
        else if (SalarioBruto > 3751.05 && SalarioBruto <= 4664.68)
        {
            return SalarioBruto * 0.225;
        }
        else if (SalarioBruto > 4664.68)
        {
            return SalarioBruto * 0.275;
        }
        return 0;
    }
}