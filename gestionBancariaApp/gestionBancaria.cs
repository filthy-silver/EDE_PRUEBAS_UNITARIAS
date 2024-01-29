using System;
using System.Windows.Forms;

/// <summary>
/// Summary description for Class1
/// </summary>
///


public class gestionBancaria
{
    public double saldo; 


    public gestionBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public double obtenerSaldo()
    {
        return saldo;
    }

    public void realizarReintegro(double cantidad)
    {
            if (cantidad < 0)
            {
                throw new ArgumentOutOfRangeException("La cantidad indicada es negativa");
            }

            if (cantidad == 0)
            {
                throw new ArgumentOutOfRangeException("La cantidad a reintegrar no puede ser 0");
            }
            else
            {
                if (cantidad > 0 && saldo >= cantidad)
                {
                    saldo -= cantidad;
                }
                else
                    throw new ArgumentOutOfRangeException("Saldo insuficiente");
            }
    }

    public void realizarIngreso(double cantidad)
    {
            if (cantidad < 0)
            {
                throw new ArgumentOutOfRangeException("La cantidad indicada es negativa");
            }

            if (cantidad == 0)
            {
                throw new ArgumentOutOfRangeException("La cantidad a ingresar no puede ser 0");
            }
            else
            {
                if (cantidad > 0)
                    saldo += cantidad;
            }
        } 
      
    }

