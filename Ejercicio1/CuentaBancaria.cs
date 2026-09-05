/*
Ejercicio 1: Implementacion de Abstraccion de Datos
*/
using System;

class CuentaBancaria {
    private decimal saldo; // El atributo debe ser privado para cumplir con la abstraccion de datos

    // Metodo para depositar dinero a la cuenta
    public void Depositar(decimal monto) {
        //Debe validarse el monto dado que no se puede hacer un deposito de $0.00
        if (monto > 0) {
            saldo += monto;
            Console.WriteLine("Depósito realizado correctamente.");
        }
        else {
            Console.WriteLine("El depósito debe ser mayor a $0.00");
        }
    }

    // Metodo para retirar dinero de la cuenta
    public void Retirar(decimal monto) {
        //Debe validarse el monto dado que no se puede hacer un deposito de $0.00
        if (monto <= 0) {
            Console.WriteLine("El monto debe ser positivo.");
        }
        else if (monto > saldo) {
            Console.WriteLine("Fondos insuficientes.");
        }
        else {
            saldo -= monto;
            Console.WriteLine("Retiro realizado correctamente.");
        }
    }

    // Metodo para consultar saldo disponible
    public decimal ObtenerSaldo() {
        return saldo;
    }
}