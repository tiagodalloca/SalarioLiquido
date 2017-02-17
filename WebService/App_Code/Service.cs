using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public bool isCPFValido(string cpf)
    {
        //extrai os dígitos do CPF
        byte num1 = (byte)char.GetNumericValue(cpf[0]);
        byte num2 = (byte)char.GetNumericValue(cpf[1]);
        byte num3 = (byte)char.GetNumericValue(cpf[2]);
        byte num4 = (byte)char.GetNumericValue(cpf[3]);
        byte num5 = (byte)char.GetNumericValue(cpf[4]);
        byte num6 = (byte)char.GetNumericValue(cpf[5]);
        byte num7 = (byte)char.GetNumericValue(cpf[6]);
        byte num8 = (byte)char.GetNumericValue(cpf[7]);
        byte num9 = (byte)char.GetNumericValue(cpf[8]);
        byte num10 = (byte)char.GetNumericValue(cpf[9]);
        byte num11 = (byte)char.GetNumericValue(cpf[10]);

        if ((num1 == num2) && (num2 == num3) && (num3 == num4) && (num4 == num5) && (num5 == num6) && (num6 == num7) && (num7 == num8) && (num8 == num9) && (num9 == num10) && (num10 == num11))
            return false;
        else
        {
            var soma1 = num1 * 10 + num2 * 9 + num3 * 8 + num4 * 7 + num5 * 6 + num6 * 5 + num7 * 4 + num8 * 3 + num9 * 2;
            var resto1 = (soma1 * 10) % 11;

            if (resto1 == 10)
                resto1 = 0;

            var soma2 = num1 * 11 + num2 * 10 + num3 * 9 + num4 * 8 + num5 * 7 + num6 * 6 + num7 * 5 + num8 * 4 + num9 * 3 + num10 * 2;
            var resto2 = (soma2 * 10) % 11;

            if (resto2 == 10)
                resto2 = 0;

            return ((resto1 == num10) && (resto2 == num11));
        }
    }

    [WebMethod]
    public double calcularIR(double salario) {
        if (1903.98 >= salario)
            return 0;
        if (2826.65 >= salario)
            return salario * 0.075;
        if (3751.05 >= salario)
            return salario * 0.15;
        if (4664.68 >= salario)
            return salario * 22.5;

        return salario * 0.275;
    }

    [WebMethod]
    public double calcularFGTS(double salario)
    {
        return salario * 0.08;
    }

    [WebMethod]
    public double calcularINSS(double salario)
    {
        if (1659.38 >= salario)
            return salario * 0.08;
        if (2765.66 >= salario)
            return salario * 0.09;

        return salario * 0.11;
    }
}