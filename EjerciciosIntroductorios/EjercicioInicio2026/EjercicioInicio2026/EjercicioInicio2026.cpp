#include "pch.h"
#include <ios>
#include <vector>
#include <string>
#include <iostream>
using namespace std;
using namespace System;

int main()
{
    vector<int> numerosPar;
    vector<int> numerosImpar;
    int numeroActual;
    bool validando = true;
    int numero;
    string entrada;
    cout << "Ingrese 10 numeros entre 1 y 100" << endl;
    int numeros[10];
    for (int contador = 0; contador < 10; contador++)
    {
        cout << "Ingrese el numero " << "(contador: " << contador << ")" << endl;
        cin >> entrada;
        while (validando)
        {

            try
            {
                numero = stoi(entrada);
                if (numero > 0 && numero < 101)
                {
                    numeros[contador] = numero;
                    validando = false;
                }
                else
                {
                    cout << "Ingrese un numero valido entre 1 y 100" << endl;
                    cin >> entrada;
                }
            }
            catch (...)
            {
                cout << "Ingrese un numero valido entre 1 y 100 " << endl;
                cout << "Ingrese el numero " << "(contador: " << contador << ")" << endl;
                cin >> entrada;
            }


        }
        validando = true;
    }
    for (int casilla = 0; casilla < 10; casilla++)
    {
        numeroActual = numeros[casilla];
        if (numeroActual % 2 == 0)
        {
            numerosPar.push_back(numeros[casilla]);
        }
        else
        {
            numerosImpar.push_back(numeros[casilla]);

        }
    }
    cout << "Numeros pares" << endl;
    for (int n = 0; n < numerosPar.size(); n++)
    {
        cout << numerosPar[n] << " ";
    }
    cout << " " << endl;
    cout << "Numeros Impares" << endl;
    for (int i = 0; i < numerosImpar.size(); i++)
    {
        cout << numerosImpar[i] << " ";
    }
}
