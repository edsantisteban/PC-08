#include "pch.h"
#include <ios>
#include <string>
#include <iostream>
using namespace std;
using namespace System;
void intercalarRecursivo(int numerosUno[5], int numerosDos[5], int numerosTres[10], int i)
{
    if (i == 5)
    {
        return;
    }

    numerosTres[2 * i] = numerosUno[i];
    numerosTres[2 * i + 1] = numerosDos[i];
    intercalarRecursivo(numerosUno, numerosDos, numerosTres, i + 1);
}
int main()
{
    int numeroActual;
    bool validando = true;
    int numero;
    string entrada;
    cout << "Ingrese 5 numeros en el array 1" << endl;
    int numerosUno[5];
    int numerosDos[5];
    int numerosTres[10];
    for (int contador = 0; contador < 5; contador++)
    {
        cout << "Ingrese el numero " << "(contador: " << contador << ")" << endl;
        cin >> entrada;
        while (validando)
        {
            try
            {
                numero = stoi(entrada);
                numerosUno[contador] = numero;
                validando = false;
            }
            catch (...)
            {
                cout << "Ingrese un numero valido" << endl;
                cout << "Ingrese el numero " << "(contador: " << contador << ")" << endl;
                cin >> entrada;
            }
        }
        validando = true;
    }
    cout << "Ingrese 5 numeros en el array 2" << endl;
    for (int contador = 0; contador < 5; contador++)
    {
        cout << "Ingrese el numero " << "(contador: " << contador << ")" << endl;
        cin >> entrada;
        while (validando)
        {
            try
            {
                numero = stoi(entrada);
                numerosDos[contador] = numero;
                validando = false;
            }
            catch (...)
            {
                cout << "Ingrese un numero valido" << endl;
                cout << "Ingrese el numero " << "(contador: " << contador << ")" << endl;
                cin >> entrada;
            }
        }
        validando = true;
    }
    intercalarRecursivo(numerosUno, numerosDos, numerosTres, 0);

    cout << "Arreglo 3 (intercalado con recursividad):"<<endl;
    for (int i = 0; i < 10; i++)
    {
        cout << numerosTres[i] << " ";
    }

}
