using System;
public class Alumno
{
    public double[] notas {get; set;}
    public string nombre{get; set;}
    public Alumno(string nombreIngresado, double[] notaIngresada)
    {
        this.notas = notaIngresada;
        this.nombre = nombreIngresado;
    }
    public double[] NotasAprobadas()
    {
        int cantidadNotas = 0;
        int posicion = 0;
        foreach(double nota in notas)
        {
            if(nota>=65)
            {
                cantidadNotas++;
            }
        }
        double[] aprobadas = new double[cantidadNotas]; 
        foreach(double nota in notas)
        {
            if(nota>=65)
            {
                aprobadas[posicion] = nota;
                posicion++;
            }
        }
        return aprobadas;

    }
    public double[] NotasReprobadas()
    {
        int cantidadNotas = 0;
        int posicion = 0;
        foreach(double nota in notas)
        {
            if(nota<=65)
            {
                cantidadNotas++;
            }
        }
        double[] reprobadas = new double[cantidadNotas]; 
        foreach(double nota in notas)
        {
            if(nota<=65)
            {
                reprobadas[posicion] = nota;
                posicion++;
            }
        }
        return reprobadas;

    }
    public double Promedio()
    {
        double sumaNotas = 0;
        double promedioAlumno = 0;
        foreach (double nota in notas)
        {
            sumaNotas += nota;
        }
        promedioAlumno = sumaNotas / notas.Length;
        return promedioAlumno;

    }



}
